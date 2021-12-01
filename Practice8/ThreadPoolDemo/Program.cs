using System;
using System.Threading;

namespace ThreadPoolDemo
{
    internal class Program
    {
        static void Main()
        {
            WaitCallback callback = new WaitCallback(ShowMyText);
            ThreadPool.QueueUserWorkItem(callback, "Hello");
            ThreadPool.QueueUserWorkItem(callback, "Hi");
            ThreadPool.QueueUserWorkItem(callback, "Heya");
            ThreadPool.QueueUserWorkItem(callback, "Goodbye");
            Console.Read();
        }

        static void ShowMyText(object state)
        {
            string myText = (string)state;
            Console.WriteLine("Thread: (0) - (1)", Thread.CurrentThread.ManagedThreadId, myText);
        }
    }
}