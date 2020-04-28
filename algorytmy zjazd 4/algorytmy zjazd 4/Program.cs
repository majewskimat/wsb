using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace algorytmy_zjazd_4
{
    class Program
    {
        private static bool IsPrime (int Num)
        {
            if (Num < 2) return false;
            else if (Num < 4) return true;
            else if (Num % 2 == 0) return false;
            else for (BigInteger u = 3; u < Num / 2; u += 2)
                    if (Num % u == 0) return false;
            return true;
        }

        private static int KolejnaPierwsza(int Num)
        {
            int u;
            if (Num < 2) return 0;
            else if (Num < 4) return Num;
            else if (Num % 2 == 0) return 0;
            else
                for ( u = 3; u < Num / 2; u += 2)
                    if (Num % u == 0) return 0;
            return Num;
        }

        public static void Main(string[] args)
        {
            int liczba;
            Boolean sux;
            /* Console.WriteLine("Podaj liczbę do analizy");
             liczba = Convert.ToInt32(Console.ReadLine());
             sux = IsPrime(liczba);
             Console.WriteLine("Wynik: " + sux);
             */


            /*for (liczba = 1; liczba <= 100; liczba+=1)
            {
                Console.Write(KolejnaPierwsza(liczba) + " ___ ");
            }
            */
            Console.ReadKey();
        }
    }
}
