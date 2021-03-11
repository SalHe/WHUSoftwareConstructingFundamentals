using System.Collections.Generic;

namespace SubmitTools.Homework.Analyzer
{
    public interface IHomeworkAnalyzer
    {

        public IList<Week> Analyze();

    }
}
