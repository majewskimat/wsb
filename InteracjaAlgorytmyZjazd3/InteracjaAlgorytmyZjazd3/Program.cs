using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InteracjaAlgorytmyZjazd3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, u, su;
            Console.WriteLine("Podaj liczbę wyrazów ciągu");
            n = Convert.ToInt32(Console.ReadLine());

            su = 0;

            for (u = 1; u <= n; u++)
            {
                su = su + u;
            }
            Console.WriteLine("Wynik: " + su);
            using (StreamWriter file = new StreamWriter(@"WriteSumaCiagu.txt", true))
            {
                file.WriteLine("Liczba wyrazów: {0}\t Wynik: {1}", n, su);
            }
            Console.ReadKey();
            
        }
    }
}
