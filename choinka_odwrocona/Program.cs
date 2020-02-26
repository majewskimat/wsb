using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace choinka_odwrocona
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź liczbę");
         
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("*");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x ; j++)
                {
                    Console.Write("");
                }
                for (int k = x; k > i ; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            
            Console.ReadKey();
        }
    }
}
