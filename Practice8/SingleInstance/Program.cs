using System;
using System.Threading;

namespace SingleInstance
{
    internal static class Program
    {
        static void Main()
        {
            Mutex oneMutex = null;
            const string mutexName = "RUNMEONLYONCE";
            try
            {
                oneMutex = Mutex.OpenExisting(mutexName);
            }
            catch (WaitHandleCannotBeOpenedException)
            {
            }

            if (oneMutex == null)
            {
                oneMutex = new Mutex(true, mutexName);
            }
            else
            {
                oneMutex.Close();
                return;
            }

            Console.WriteLine("Our Application");
        }
    }
}