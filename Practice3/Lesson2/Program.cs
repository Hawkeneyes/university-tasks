using System.Text;
using System.IO;

namespace Lesson2
{
    internal class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"..\..\..\boot.ini");
            StreamWriter sw = new StreamWriter(@"..\..\..\boot-utf7.txt", false, Encoding.UTF7);
            sw.WriteLine(sr.ReadToEnd());
            sw.Close();
            sr.Close();
        }
    }
}