using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<InstrumentMuzical> orchestra = new List<InstrumentMuzical>();

            InstrumentMuzical instr;
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                switch (rnd.Next(2))
                {
                    case 0:
                        instr = new Chitara(6, 10);
                        orchestra.Add(instr);
                        break;
                    case 1:
                        instr = new Vioara(4, 8);
                        orchestra.Add(instr);
                        break;
                    default:
                        break;
                }
                
            }

            foreach (InstrumentMuzical item in orchestra)
            {
                item.AcordeazaInstrument();
            }
        }
    }
}
