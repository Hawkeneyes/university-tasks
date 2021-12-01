using System;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main()
        {
            StreamWriter writer = File.CreateText(@"D:\temp\newfile.txt"); 
            writer.WriteLine("This is my new file"); 
            writer.WriteLine("Do you like its format?"); 
            writer.Close();

            StreamReader reader = File.OpenText(@"c:\newfile.txt");
            string contents = reader.ReadToEnd();
            reader. Close();
            Console.WriteLine(contents);
        }
    }
}
