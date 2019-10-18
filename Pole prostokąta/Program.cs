using System;

namespace Pole_prostokąta
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\nProgram obliczający pole prostokąta");

                double a, b, wynik;

                Console.Write("\nPodaj w cm długość boku a: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("\nPodaj w cm długość boku b: ");
                b = double.Parse(Console.ReadLine());

                wynik = a * b;

                if (a > 0 & b > 0)

                {
                    Console.WriteLine("\n\nPole prostokąta wynosi: " + wynik + " cm/kw");
                }

                else

                {
                    Console.WriteLine("\n\nBłędne dane podane z klawiatury");
                }
            }

            catch (Exception)
            {
                Console.WriteLine("\n\nBłędne dane podane z klawiatury");
            }


            Console.ReadKey();

        }
    }
}
