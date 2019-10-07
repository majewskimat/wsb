using System;

namespace _1_first_file
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz
            Console.Write("Imię: "); //wyświetli Imię:
            Console.WriteLine("Kasia");

            /* komentarz
             * w wielu
             * liniach
             */

            /*
             *      #
             *      ##
             *      ###
             *      ####
             */

            Console.WriteLine("\n#\n##\n###\n####");

            string name;
            name = "Janusz";

            // + konkatenacja
            Console.WriteLine("\nMasz na imię: " + name);

            Console.WriteLine("Masz na imię: {0}", name);

            int age = 20;
            Console.WriteLine("Masz na imię: {0}, wiek: {1}", age, name);

            sbyte age1 = 127;
            Console.WriteLine("Masz na imię: {0}, wiek1: {1}", age1, name);

            /*
             * Użytkownik podaje z klawiatury długość boku
             * Oblicz pole kwadratu
             */

            Console.Write("Podaj bok a:");
            string a = Console.ReadLine();

            //Console.WriteLine("Bok a:{0}",a);

            double result = double.Parse(a) * double.Parse(a);
            Console.WriteLine("Pole kwadratu wynosi: {0}", result);

            /*
             * Oblicz pole trójkąta
             * dane podaje użytkownik z klawiatury
             */

            Console.Clear();

            //zajęcia 2
            //użytkownik podaje liczbę z klawiatury
            string str;
            int liczba;

            Console.Write("Podaj liczbę:");
            str = Console.ReadLine();
            //liczba = int.Parse(str);

            if (int.TryParse(str, out liczba) == false)
            {
                Console.WriteLine("Podałeś błędne dane!");
            }
            else
            {
                Console.WriteLine("Liczba wynosi: {0}", liczba);
            }


            /*
             * Sprawdź czy dane podane z klawiatury są liczbą całkowitą dodatnią
             * sprawdź czy liczba jest nieparzysta
             */
            Console.Clear();
            string number;
            uint numberUint;
            Console.Write("Podaj liczbę całkowitą dodatnią:");
            number = Console.ReadLine();

            if (uint.TryParse(number, out numberUint) == true)
            {
                if (numberUint % 2 != 0)
                {
                    Console.WriteLine("Liczba {0} jest nieparzysta", numberUint);
                }
                else
                {
                    Console.WriteLine("Liczba {0} jest parzysta", numberUint);
                }
            }
            else
            {
                Console.WriteLine("Podałeś błędne dane o wartości: {0}", number);
            }

            /*
            * Użytkownik podaje z klawiatury dane dwóch boków
            * Oblicz pole prostokąta i obwód
            *
            * Wyświetl w formacie:
            * Pole prostokąta wynosi: ...
            * Obwód prostokąta wynosi: ...
            *
            * Sprawdź czy dane z klawiatury są poprawne
            * W przypadku błędnych danych wyświetl na ekranie komunikat:
            * "Podałeś błędne dane!"
            */
            Console.Clear();
            byte age2 = 17;

            if (age2 == 18)
            {
                Console.WriteLine("Masz 18 lat");
            }
            else if (age2 < 18)
            {
                Console.WriteLine("Jesteś niepełnoletni");
            }
            else
            {
                Console.WriteLine("Jesteś pełnoletni");
                Console.WriteLine("Masz {0} lat\n", age2);
            }

            //switch

            liczba = 21;
            switch (liczba)
            {
                case 10:
                    Console.WriteLine("Liczba = 10");
                    break;
                case 20:
                    Console.WriteLine("Liczba = 20");
                    break;
                case 30:
                    Console.WriteLine("Liczba = 30");
                    break;
                default:
                    Console.WriteLine("Liczba wynosi: {0}", liczba);
                    break;
            }

            Console.Clear();

            /*
             * Napisz program, która ma następujące menu
             *
             * a - Pole kwadratu
             * b - Pole prostokąta
             *
             * Wykorzystaj instrukcję switch
             * Zabezpiecz dane przed podaniem błędnych wartości do obliczeń
             */

            Console.WriteLine("a - Pole kwadratu\nb - Pole prostokąta");
            Console.Write("Wybierz jedną z opcji:");

            string znak = Console.ReadLine();
            string bokA, bokB;
            double a1, b1, pole;
            Console.Clear();

            switch (znak)
            {
                case "a":
                    Console.WriteLine("Obliczanie pola kwadratu");
                    Console.Write("Podaj a:");
                    bokA = Console.ReadLine();

                    if (double.TryParse(bokA, out a1))
                    {
                        pole = a1 * a1;
                        Console.WriteLine("Pole kwadratu wynosi: {0}", pole);
                    }
                    else
                    {
                        Console.WriteLine("Podałeś błędne dane");
                    }
                    break;
                case "b":
                    Console.WriteLine("Obliczanie pola prostokąta");
                    Console.Write("Podaj a:");
                    bokA = Console.ReadLine();
                    Console.Write("Podaj b:");
                    bokB = Console.ReadLine();

                    if (double.TryParse(bokA, out a1) && double.TryParse(bokB, out b1))
                    {
                        pole = a1 * b1;
                        Console.WriteLine("Pole prostokąta wynosi: {0}", pole);
                    }
                    else
                    {
                        Console.WriteLine("Podałeś błędne dane");
                    }
                    break;
            }

            Console.Clear();

            //wyświetl liczby <1,15>
            int i, j;

            for (i = 1; i <= 15; i++)
            {
                Console.Write(i + " ");
            }

            for (i = 1; i <= 10; i++)
            {
                for (j = 10; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
