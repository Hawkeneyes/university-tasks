using System;

namespace CreateStruct3
{
    class Program
    {
        static void Main()
        {
            Person p = new Person("Tony", "Allen", 32, Person.Genders.Male);
            Console.WriteLine(p.ToString());

            Manager m = new Manager("Tony", "Allen", 32, Person.Genders.Male, "555-555-1212", "123b");
            Console.WriteLine(m);
            //Console.ReadLine();
        }

        class Person
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public Genders Gender;

            public Person(string firstName, string lastName, int age, Genders gender)
            {
                this.FirstName = firstName;
                LastName = lastName;
                Age = age;
                Gender = gender;
            }

            public override string ToString()
            {
                return FirstName + " " + LastName + " (" + Gender + "), age " + Age;
            }

            public enum Genders
            {
                Male,
                Female
            }
        }

        class Manager : Person
        {
            string _phoneNumber;
            string _officeLocation;

            public Manager(string firstName, string lastName, int age, Genders gender, string phoneNumber, string officeLocation)
                : base(firstName, lastName, age, gender)
            {
                this._phoneNumber = phoneNumber;
                this._officeLocation = officeLocation;
            }

            public override string ToString()
            {
                return base.ToString() + ", " + _phoneNumber + ", " + _officeLocation;
            }
        }
    }
}