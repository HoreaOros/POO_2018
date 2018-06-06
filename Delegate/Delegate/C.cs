using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class C
    {
        public delegate int Op(int x, int y);

        public void Compute(int x, int y, Op del)
        {
            if (del != null)
            {
                Console.WriteLine(del(x, y));
            }
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Diff(int x, int y)
        {
            return x - y;
        }


        public delegate int Func(int x);


        public static int Dublu(int x)
        {
            Console.WriteLine("S-a apelat metoda Dublu()");
            return 2 * x;
        }
        public static int Triplu(int x)
        {
            Console.WriteLine("S-a apelat metoda Triplu()");
            return 3 * x;
        }

        public void Compute2(int x, Func f)
        {
            Console.WriteLine(f(x));
        }
    }
}
