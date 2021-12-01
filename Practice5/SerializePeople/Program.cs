using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace SerializePeople
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
            FileStream fs = new FileStream("Person.Dat", FileMode.Create);
            
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, sp);
            
            fs.Close();
        }

        private static Person Deserialize()
        {
            FileStream fs = new FileStream("Person.Dat", FileMode.Open);
            
            BinaryFormatter bf = new BinaryFormatter();
            
            var dsp = (Person)bf.Deserialize(fs);
            
            fs.Close();

            return dsp;
        }
    }
}