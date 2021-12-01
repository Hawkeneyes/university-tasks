using System;

namespace Mihalich_zver
{
    internal static class Program
    {
        static sbyte a = 0;
        static byte b = 0;
        static short c = 0;
        static int d = 0;
        static long e = 0;
        static string s = "";
        private static readonly Exception Ex = new Exception();
        private static readonly object[] Types = {a, b, c, d, e, s, Ex};

        private static void Main()
        {
            foreach (object element in Types)
            {
                string type = element.GetType().IsValueType ? "Value type" : "Reference Type";
                Console.WriteLine("{0}: {1}", element.GetType(), type);
            }
        }
    }
}
