using System;
using System.IO;


namespace ProjektWzorcowy
{

    class Program
    {
        static ulong AddNumber;
        static uint fib(uint n)
        {
            switch (n)
            {
                case 0: return 1;
                case 1: return 1;
                default: AddNumber++; return fib(n - 1) + fib(n - 2);
            }
        } /* fib() */
        static void Main(string[] args)
        {
            //Wypisuje wynik programu w pliku cz.1
            using (StreamWriter file = new StreamWriter(@"WriteFibon3.txt", true))
            {
                file.WriteLine("n\tWynik");
            }
            //Wypisuje wynik programu w pliku cz.2
            using (StreamWriter file = new StreamWriter(@"WriteFibon3.txt", true))
                for (uint u = 0; u < 45; u++)
                {
                    AddNumber = 0;
                    ulong r = fib(u);
                    file.WriteLine("{0}\t{1}", u, AddNumber);
                }
        }
    }
}
