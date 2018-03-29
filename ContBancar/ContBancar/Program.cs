using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContBancar
{
    class Program
    {
        static void Main(string[] args)
        {
            Cont c1 = new Cont("John Doe", 777);
            Cont c2 = new Cont("Jane Doe");

            try
            {
                c1.Retrage(100);
                c1.Retrage(1000);
            }
            catch (InvalidAmountException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                c2.Depune(100);
                c2.Retrage(50);
                c2.Depune(-100);
                c2.Retrage(50); // nu se mai executa pentru ca 
                // instructiunea anterioara lanseaza exceptie
            }
            catch (InvalidAmountException e)
            {
                Console.WriteLine(e.Message);
            }

            c2.ShowDetails();

            c2.PrintTranzactii();
        }
    }
}
