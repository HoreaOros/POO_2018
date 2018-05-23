using System;
using System.Collections;

namespace Interface
{
    internal class SumComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return DigitSum((int)x) - DigitSum((int)y);
        }

        private int DigitSum(int x)
        {
            int suma = 0;
            while (x > 0)
            {
                suma += x % 10;
                x = x / 10;
            }
            return suma;
        }
    }
}