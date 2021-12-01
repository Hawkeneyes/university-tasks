using System;
using System.IO;
using System.Xml.Serialization;


namespace SerializePeopleXML
{
    static class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Person p = Deserialize();
                Console.WriteLine(p.ToString());
            }
            else
            {
                try
                {
                    if (args.Length != 4)
                    {
                        throw new ArgumentException("You must provide four arguments: name, year, month, date.");
                    }

                    DateTime dob = new DateTime(int.Parse(args[1]), int.Parse(args[2]), int.Parse(args[3]));
                    Person p = new Person(args[0], dob);
                    Console.WriteLine(p.ToString());

                    Serialize(p);
                }
                catch (Exception ex)
                {
                    DisplayUsageInformation(ex.Message);
                }
            }
        }

        private static void DisplayUsageInformation(string message)
        {
            Console.WriteLine("\nERROR: Invalid parameters. " + message);
            Console.WriteLine("For example: \"Lesson5-Practice1-SerializePeople \"Tony\" 1922 11 22\".");
            Console.WriteLine("Or, run the command with no arguments to display that previous person.");
        }

        private static void Serialize(Person sp)
        {
            FileStream fs = new FileStream("Person.XML", FileMode.Create);
            
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            xs.Serialize(fs, sp);
            fs.Close();
        }

        private static Person Deserialize()
        {
            FileStream fs = new FileStream("Person.XML", FileMode.Open);
            
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            
            var dsp = (Person)xs.Deserialize(fs);
            
            fs.Close();

            return dsp;
        }
    }
}