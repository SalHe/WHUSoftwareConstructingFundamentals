using System.Collections.Generic;

namespace SubmitTools.Homework
{
    public class Week
    {

        public int WeekId { get; }
        
        public List<Question> Questions { get; }

        public List<CsProject> CsProjects { get; }

        public Week(int weekId)
        {
            WeekId = weekId;
            Questions = new List<Question>();
            CsProjects = new List<CsProject>();
        }
    }
}
