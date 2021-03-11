using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SubmitTools.Homework.Analyzer
{
    public class SalHeHomeworkAnalyzer : IHomeworkAnalyzer
    {

        private string ReadMePath;

        private string PeriodPath;

        public SalHeHomeworkAnalyzer() : this(
            Path.Join(Directory.GetCurrentDirectory(), "README.md"),
            Path.Join(Directory.GetCurrentDirectory(), "Period")
        )
        {

        }

        public SalHeHomeworkAnalyzer(string readMePath, string periodPath)
        {
            ReadMePath = readMePath;
            PeriodPath = periodPath;
        }

        //private List<Week> _weeks;

        public IList<Week> Analyze()
        {
            List<Week> _weeks = new List<Week>();


            // 解析 README.md 获取每周作业内容
            bool homeworkBegin = false;
            Week currentWeek = null;
            int weekCount = 0;

            foreach (var line in File.ReadAllLines(ReadMePath))
            {
                var lineTrimmed = line.Trim();
                if (lineTrimmed == "") continue;

                if (lineTrimmed.StartsWith("## "))
                {
                    homeworkBegin = lineTrimmed == "## 作业";
                }
                else if (homeworkBegin)
                {
                    if (lineTrimmed.StartsWith("- "))
                    {
                        if(weekCount > 0)
                            _weeks.Add(currentWeek);

                        weekCount++;
                        currentWeek = new Week(weekCount);
                    }
                    else
                    {
                        currentWeek?.Questions.Add(new Question()
                        {
                            Content = lineTrimmed
                        });
                    }
                }
            }

            if(weekCount > _weeks.Count) _weeks.Add(currentWeek);

            // 在 Period 搜寻每个周拥有的工程
            int dirCounter = 0;
            foreach (var dir in Directory.EnumerateDirectories(PeriodPath))
            {
                // Period/<dir>

                bool isWeekDir = false;
                foreach (var subDir in Directory.EnumerateDirectories(dir))
                {
                    // Period/****/<subDir>
                    if (Directory.GetFiles(subDir, "*.csproj").Length != 0)
                    {
                        // 是一个有效的C#工程目录
                        if (!isWeekDir)
                        {
                            dirCounter++;
                            isWeekDir = true;
                        }

                        _weeks[dirCounter-1].CsProjects.Add(new CsProject(){ ProjectPath = subDir});
                    }
                }
            }

            return _weeks;
        }
    }
}
