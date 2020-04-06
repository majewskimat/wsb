using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SumowanieLiczbParzystych
{
    class Program
    {

        private static int SumaLiczbParzystych(int n)
        {
            if (n % 2 == 0)
            {
                if (n >= 1)
                    return n + SumaLiczbParzystych(n - 1);
                else
                    return 0;
            }
        
            return SumaLiczbParzystych(n - 1);
        }

        static void Main(string[] args)
        {
            int l, u, sumar, sumai;

            Console.WriteLine("Podaj liczbę wyrazów ciągu:");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            
            sumai = 0;

            for (u = 1; u <= l; u++)
            {
                if (u % 2 == 0)
                {
                    sumai += u;
                }
            }

            sumar = SumaLiczbParzystych(l);

            Console.WriteLine("Liczba wyrazów: {0}\t Suma liczb parzystych metodą rekurencyjną: {1}", l, sumar);
            Console.WriteLine("Liczba wyrazów: {0}\t Suma liczb parzystych metodą interacyjną: {1}", l, sumai);

            // Poniżej zakomentowałem kod pozwalający zapisać wynik w pliku tekstowym. W razie potrzeby wystarczy usunąć komentarz i będzie działać.

            /*
            using (StreamWriter file = new StreamWriter(@"WriteSumaLiczbParzystych.txt", true))
            {
                file.WriteLine("Liczba wyrazów: {0}\t Suma liczb parzystych metodą rekurencyjną: {1}", l, sumar);
                file.WriteLine("Liczba wyrazów: {0}\t Suma liczb parzystych metodą interacyjną: {1}", l, sumai);
            }
            */

            Console.ReadKey();
        }
    }
}
