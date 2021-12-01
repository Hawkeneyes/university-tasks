using System;

namespace Practice6
{
    internal sealed class Paper
    {
        private string PapTitle { get; }
        private Person PapAuthor { get; }
        private DateTime PapDate { get; }
        
        public Paper(string papTitle, Person papAuthor, DateTime papDate)
        {
            PapTitle = papTitle;
            PapAuthor = papAuthor;
            PapDate = papDate;
        }

        public Paper() : this("Title", new Person(), DateTime.MinValue)
        {
        }
        
        public override string ToString() => $"{PapTitle} ({PapDate:MMMM dd, yyyy}) by {PapAuthor}";
    }
}