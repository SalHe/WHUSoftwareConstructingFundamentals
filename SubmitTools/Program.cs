using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Linq;
using SubmitTools.Homework;
using SubmitTools.Homework.Analyzer;

namespace SubmitTools
{
    public class Program
    {
        private static IList<Week> weeks;

        public static int Main(string[] args)
        {

            IHomeworkAnalyzer homeworkAnalyzer = new SalHeHomeworkAnalyzer();
            weeks = homeworkAnalyzer.Analyze();



            RootCommand rootCommand = new RootCommand("自动打包作业，发送给学委的小工具（按照本仓库实例组装代码）。");

            rootCommand.AddCommand(new Command("list", "列出分析出来的作业列表。")
            {
                Handler = CommandHandler.Create(ListHomework)
            });
            var command = new Command("pack", "打包一份作业。");
            command.AddOption(new Option<int>(new[] { "--week", "-w" }, () => weeks.Count));
            command.AddOption(new Option<string>(new[] { "--project", "-p" }, () => weeks.Last().CsProjects.Last().ProjectName ?? ""));
            command.AddOption(new Option<bool>(new[] { "--submit", "-s" }, () => false));
            command.AddOption(new Option<string>(new[] { "--receiver", "-r" }, () => "1746521439@qq.com"));
            command.Handler = CommandHandler.Create<CLIArgs>(PackageHomework);
            rootCommand.AddCommand(command);

            return rootCommand.InvokeAsync(args).Result;
        }

        public static void ListHomework()
        {
            foreach (var week in weeks)
            {
                Console.WriteLine("----------------------------------------------------------------");

                Console.WriteLine();
                Console.WriteLine($"第 {week.WeekId} 周作业");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("作业内容：");
                Console.WriteLine();
                week.Questions.ForEach(t => Console.WriteLine(t.Content));

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("工程列表：");
                Console.WriteLine();
                int c = 0;
                week.CsProjects.ForEach(t =>
                {
                    c++;
                    Console.WriteLine($"Project {c:D2}");
                    Console.WriteLine(Path.GetFileName(t.ProjectPath));
                    Console.WriteLine(t.ProjectPath);
                    Console.WriteLine();
                });

                Console.WriteLine("----------------------------------------------------------------");
            }
        }

        public static void PackageHomework(CLIArgs args)
        {

        }
    }
}
