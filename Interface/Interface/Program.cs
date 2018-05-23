using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[] { 34, 57, 111, 9, 42 };

            Print(v);

            Array.Sort(v);

            Print(v);


            Array.Sort(v, new SumComparer());

            Print(v);
        }

        private static void Print(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("{0} ", v[i]);
            }
            Console.WriteLine();
        }
    }
}
