using System;

namespace Delegate
{
    internal class Util
    {
        internal static bool IsPrime(int x)
        {
            if (x < 2)
                return false;
            if (x == 2)
                return true;
            if (x % 2 == 0)
            {
                return false;
            }
            for (int d = 3; d*d <= x; d++)
            {
                if (x % d == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}