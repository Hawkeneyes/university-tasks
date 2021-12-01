using System;
using System.IO;

namespace ShowFilesDemo
{
    class Program
    {
        static void ShowDirectory(DirectoryInfo dir)
        {
            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine("File: {0}", file.FullName);
            }

            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                ShowDirectory(subDir);
            }
        }

        static void Main()
        {
            DirectoryInfo dir = new(Environment.SystemDirectory);
            ShowDirectory(dir);
        }
    }
}
