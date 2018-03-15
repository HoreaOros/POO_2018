using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            World w1 = new World("W1");
            w1.SayHello();
            Console.WriteLine(w1.GID);

            World w2 = new World("W2");
            w2.SayHello();

            w2.SayHello(true);
            w2.SayHello(false);
        }
    }
}
