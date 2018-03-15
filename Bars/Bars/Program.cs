using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bars
{
    class Program
    {
        static void Main(string[] args)
        {
            HorzBar h1 = new HorzBar(4);

            VertBar v1 = new VertBar(3);


            Frame f1 = new Frame(3, 2);

            Ladder ladd = new Ladder(20, 3, 2);
        }
    }
}
