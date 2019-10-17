using System;

namespace Pole_prostokąta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nProgram obliczający pole prostokąta");

            double a, b, wynik;

            Console.Write("\nPodaj w cm długość boku b: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("\nPodaj w cm długość boku b: ");
            b = double.Parse(Console.ReadLine());

            wynik = a * b;

            if (a > 0 & b > 0)

            {
                Console.WriteLine("\nPole prostokąta wynosi: " + wynik + " cm/kw\n");

            }

            else
            {
                Console.WriteLine("\nBłędne dane podane z klawiatury\n");          
            }
            Console.ReadKey();
        }
    }
}
