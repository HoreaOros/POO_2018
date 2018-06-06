using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();

            C.Op d = new C.Op(C.Diff);

            c.Compute(1, 2, d);

            C.Func f = C.Dublu;
            f += C.Triplu;

            c.Compute2(2, f);

            Func<int, int> f2;


            List<int> lst = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                lst.Add(i);
            }


            foreach (var item in lst.FindAll(Util.IsPrime))
            {
                Console.WriteLine(item);
            }
            
            

        }

        
    }
}
