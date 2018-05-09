using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            line = Console.ReadLine();

            //Console.WriteLine(line);
            char[] sep = {' ', ';', ','};
            string[] words = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            string s1 = "Șase";
            string s2 = "Tase";

            if (s1 == s2)
            {
                Console.WriteLine("s1 == s2");
            }
            else
                Console.WriteLine("s1 != s2");

            if (s1.CompareTo(s2) < 0)
            {
                Console.WriteLine("s1 < s2");
            }
            else
                Console.WriteLine("s1 >= s2");



        }
    }
}
