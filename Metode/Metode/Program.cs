using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metode;

namespace MyMetode
{
    class Program
    {
        static void F()
        {
            int n; // variabila locala
            Console.WriteLine("f()");
            n = 314; 
            Console.WriteLine(n);


        }
        static void Main(string[] args)
        {
            F();

            XClass.Xc();


            XClass x1 = new XClass();
            XClass x2 = new XClass();
            XClass x3 = new XClass();

            x1.id2 = 408;
            x2.id2 = 808;
            x3.id2 = 909;


           Singleton sng = Singleton.getInstance();

           Singleton sng2 = Singleton.getInstance();
        }
    }
}
