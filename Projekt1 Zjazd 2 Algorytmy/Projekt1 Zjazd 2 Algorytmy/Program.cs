using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Projekt1_Zjazd_2_Algorytmy
{
    class Program
    {
        
        static ulong AddNumber;
        static uint sil(uint n)
        {
            switch(n)
            {
                case 0: return 1;
                case 1: return 1;
                default: AddNumber++; return n * sil(n - 1);
            }
        } /*sil()*/
        static void Main(string[] args)
        {
            using (StreamWriter file = new StreamWriter(@"WriteFibon3.txt", true))
            {
                file.WriteLine("n\tWynik");
            }
            using (StreamWriter file = new StreamWriter(@"WriteFibon3.txt", true))
                for (uint u = 1; u < 15; u++)
                {
                    AddNumber = sil(u - 1);
                    file.WriteLine("{0}\t{1}", u, AddNumber);
                }
           
        }
    }
}
