using System.IO;

namespace SubmitTools.Homework
{
    public class CsProject
    {

        public string ProjectPath { get; set; }

        public string ProjectName => Path.GetFileName(ProjectPath);

    }
}
