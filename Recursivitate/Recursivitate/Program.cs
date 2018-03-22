using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivitate
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = 6;

            //Console.WriteLine("n! = {0}", factorial(n));
            ulong a = 7;
            ulong k = 1258965874;
            ulong p = 666083;

            Console.WriteLine("{0} ^ {1} mod {2} = {3}", a, k, p, expLog(a, k, p));


            Dyno();
        }

        private static void Dyno()
        {
            string[] dinosaurs = {"Pachycephalosaurus",
                              "Amargasaurus",
                              "Tyrannosaurus",
                              "Mamenchisaurus",
                              "Deinonychus",
                              "Edmontosaurus"};

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nSort");
            Array.Sort(dinosaurs);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            if (MyBinSearch(dinosaurs, "Mamenchisaurus"))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        private static bool MyBinSearch(string[] dinosaurs, string v)
        {
            return MyBinSearchHelper(dinosaurs, v, 0, dinosaurs.Length - 1);
        }

        private static bool MyBinSearchHelper(string[] dinosaurs, string dino, int left, int right)
        {
            int mid;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (dinosaurs[mid] == dino)
                {
                    return true;
                }
                else if (string.Compare(dino, dinosaurs[mid]) < 0)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return false;
        }

        private static ulong expLog(ulong a, ulong k, ulong p)
        {
            if (k == 0)
            {
                return 1;
            }
            else if (k % 2 == 0)
            {
                ulong t;
                t = expLog(a, k / 2, p);
                t = t % p;
                return (t * t) % p;
            }
            else
                return (a % p) * (expLog(a, k - 1, p) % p) % p;
        }

        private static int factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                int p;
                p = n * factorial(n - 1);
                return p;
            }
        }

    }
}
