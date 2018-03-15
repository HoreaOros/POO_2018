using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMetode
{
    public class XClass
    {
        public static int id = 42;
        public int id2 = 404;
        public static void Xc()
        {
            Console.WriteLine("xc()");
            // id2 = 405; // nu se poate

            id = 43;
        }
        public void Xc2()
        {
            id2 = 405;

            id = 43;
        }
    }
}
