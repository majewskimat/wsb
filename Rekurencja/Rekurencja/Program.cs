using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rekurencja
{
    class Program
    {
        private static int sumaciagu(int n)
        {
            if (n < 1)
                return 0;
            else
                return n + sumaciagu(n - 1);
        }
        static void Main(string[] args)
        {
            int u, sux;
            Console.WriteLine("Podaj liczbę wyrazów ciągu");
            u = Convert.ToInt32(Console.ReadLine());
            sux = sumaciagu(u);
            Console.WriteLine("{0}\t{1}", u, sux);
            using (StreamWriter file = new StreamWriter(@"WriteSumaCiagu.txt", true))
            {
                file.WriteLine("Liczba wyrazów: {0}\t ynik: {1}", u, sux);
            }
            Console.ReadKey();

        }
    }
}
