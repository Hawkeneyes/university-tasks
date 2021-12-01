using System;
using System.IO;

namespace FileWatchingDemo
{
    class Program
    {
        static void WatcherChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed: {0}", e.FullPath);
        }

        static void Main()
        {
            FileSystemWatcher watcher = new FileSystemWatcher(@"D:\temp")
            {
                Filter = "*.*",
                IncludeSubdirectories = true,
                NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size
            };
            watcher.Changed += WatcherChanged;
            Console.ReadKey();
        }
    }
}
