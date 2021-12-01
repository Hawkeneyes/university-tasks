using System.Collections.Generic;

namespace Practice6
{
    internal sealed class ResearchTeam
    {
        private string _researchTitle;
        private string _organization;
        private int _regNumber;
        private TimeFrame _duration;
        private readonly List<Paper> _papers = new List<Paper>();

        public string ResearchTitle
        {
            get => _researchTitle; 
            set => _researchTitle = value;
        }

        public string Organization 
        {
            get => _organization;
            set => _organization = value;
        }

        public int RegNumber
        {
            get => _regNumber; 
            set => _regNumber = value;
        }

        public TimeFrame Duration
        {
            get => _duration; 
            set => _duration = value;
        }

        public IReadOnlyList<Paper> Papers => _papers.AsReadOnly();

        private ResearchTeam(string researchTitle, string organization, int regNumber, TimeFrame duration)
        {
            _researchTitle = researchTitle;
            _organization = organization;
            _regNumber = regNumber;
            _duration = duration;
        }

        public ResearchTeam() : this("Title", "Organization", 29903, TimeFrame.Long)
        {
        }
        
        public Paper LatestPaper => _papers.Count > 0 ? _papers[_papers.Count - 1] : null;
        
        public bool this[TimeFrame frame] => _duration == frame;
        
        public void AddPapers(params Paper[] paps) => _papers.AddRange(paps);

        public override string ToString()
        {
            string res = $"Title: {_researchTitle}\nOrganization: {_organization}\nRegistration Number: {_regNumber}" +
                $"\nResearch Duration: {_duration}\nResearch papers:";
            if (_papers.Count == 0)
                res += "\nNone";
            else
                foreach (Paper paper in _papers)
                    res += $"\n{_papers.IndexOf(paper) + 1}. {paper}";
            return res;
        }
        
        public string ToShortString() => $"Title: {_researchTitle}\nOrganization: {_organization}" +
                                         $"\nRegistration Number: {_regNumber}\nResearch Duration: {_duration}";
    }
}