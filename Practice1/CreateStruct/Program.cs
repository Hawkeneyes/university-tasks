using System;

namespace CreateStruct
{
    internal readonly struct Person
    {
        public enum Genders
        { 
            Male, 
            Female,
            Custom
        }

        private readonly string _firstname;
        private readonly string _lastname;
        private readonly int _age;
        private readonly Genders _gender;

        internal Person(string firstname, string lastname, int age, Genders gender)
        {
            _firstname = firstname;
            _lastname = lastname;
            _age = age;
            this._gender = gender;
        }

        public override string ToString()
        {
            return _firstname + " " + _lastname + " (" + _gender + ") age " + _age;
        }
    }

    internal static class Program
    {
        private static void Main()
        {
            Person p = new Person("Tony", "Allen", 32, Person.Genders.Male);
            Console.WriteLine(p);
        }
    }
}