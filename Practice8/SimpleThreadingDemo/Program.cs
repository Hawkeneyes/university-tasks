using System;
using System.Threading;

namespace SimpleThreadingDemo
{
    internal static class Program
    {
        static void Main()
        {
            ThreadStart starter = Counting;
            Thread first = new Thread(starter);
            Thread second = new Thread(starter);
            first.Start();
            second.Start();
            first.Join();
            second.Join();
        }

        static void Counting()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Count: {0} - Thread' {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
        }
    }
}