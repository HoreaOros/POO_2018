using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataC
{
    public enum LunileAnului
    {
        Ian,
        Feb,
        Mar,
        Apr,
        Mai,
        Iun,
        Iul,
        Aug,
        Sept,
        Oct,
        Nov,
        Dec
    }
    public struct DataCalendaristica
    {
        private int zi;
        private LunileAnului luna;
        private int an;

        public DataCalendaristica(int z, LunileAnului la, int a)
        {
            zi = z;
            luna = la;
            an = a;
        }
        public void SetZi(int d)
        {
            zi = d;
        }

        internal void SetLuna(LunileAnului lu)
        {
            luna = lu;
        }

        internal void SetAn(int v)
        {
            an = v;
        }
    }
}