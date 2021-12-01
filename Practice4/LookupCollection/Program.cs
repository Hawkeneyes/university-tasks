using System;
using System.Globalization;
using System.Collections;
using System.Collections.Specialized;

namespace LookupCollection
{
    internal class Program
    {
        static void Main()
        {
            ListDictionary list = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));
            
            list["Estados Unidos"] = "United States of America";
            list["Canada"] = "Canada";
            list["Espana"] = "Spain";
            
            Console.WriteLine(list["espana"]);
            Console.WriteLine(list["CANADA"]);
        }
    }
}