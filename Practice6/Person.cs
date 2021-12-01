using System;

namespace Practice6
{
    internal sealed class Person
    {
        private string Name { get; }
        private string Surname { get; }
        private DateTime BirthDate { get; set; }

        public int BirthYear 
        {
            get => BirthDate.Year;
            set => BirthDate = new DateTime(value, BirthDate.Month, BirthDate.Day);
        }

        public Person(string name, string surname, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }

        public Person() : this("Ivan", "Ivanov", DateTime.MinValue) 
        {
        }

        public override string ToString() => $"{Name} {Surname} ({BirthDate:MMMM dd, yyyy})";

        public string ToShortString() => $"{Name} {Surname}";
    }
}