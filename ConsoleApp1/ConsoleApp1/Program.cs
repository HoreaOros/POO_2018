using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataC;
namespace ConsoleApp1
{
    enum Zile
    {
        Luni,
        Marti,
        Miercuri,
        Joi,
        Vineri,
        Sambata,
        Duminica
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zile z = Zile.Miercuri;

            switch (z)
            {
                case Zile.Luni:
                    break;
                case Zile.Marti:
                    break;
                case Zile.Miercuri:
                    break;
                case Zile.Joi:
                    break;
                case Zile.Vineri:
                    break;
                case Zile.Sambata:
                    break;
                case Zile.Duminica:
                    break;
                default:
                    break;
            }
            Zile z2 = (Zile)3;
            Console.WriteLine(z2);

            DataC.DataCalendaristica dc = new DataC.DataCalendaristica();
            dc.SetZi(7);
            dc.SetLuna(LunileAnului.Mai);
            dc.SetAn(2018);
            


        }
    }
}
