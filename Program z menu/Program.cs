using System;


namespace Zadanie_z_labów_cw_2_z_moodla
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int parzystosc;
            string parzystosc_;
            Console.WriteLine("Podaj liczbę aby sprawdzić czy liczba jest parzysta: ");
            parzystosc_ = Console.ReadLine();
            parzystosc = int.Parse(parzystosc_);
            if (parzystosc % 2 !=0 )
            {
                Console.WriteLine("Jest to liczba niepaprzysty");
            }
            else
            {
                Console.WriteLine("Jest to liczba parzysta");
            }
            

            
            Console.WriteLine("Podaj wartość a: ");
            string a_ = Console.ReadLine();
            Console.WriteLine("Podaj wartośc b: ");
            string b_ = Console.ReadLine();
            double a = double.Parse(a_);
            double b = double.Parse(b_);
            double ab = (a * b) / (a + b);
            Console.WriteLine("wynik działania wynosi {0}", ab); 
            

            double wynik, liczba1_, liczba2_,elo;
            string wybor, koniec, liczba1, liczba2;





            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowania");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");

            wybor = Console.ReadLine();
            




            Console.Clear();

            switch (wybor)
            {
                case "1":
                    Console.WriteLine("Wpisz pierwszą wartość");
                    liczba1 = Console.ReadLine();
                    if (double.TryParse(liczba1, out liczba1_) == false)
                    {
                        Console.WriteLine("Podałeś złe dane");
                    }
                    Console.WriteLine("Podaj drugą wartość");
                    liczba2 = Console.ReadLine();
                    if (double.TryParse(liczba2, out liczba2_) == false)
                    {
                        Console.WriteLine("Podałeś złe dane");
                    }
                    else
                        Console.WriteLine("Wynik wynosi: " + (liczba1_ + liczba2_));
                    break;

                case "2":
                    Console.WriteLine("Wpisz pierwszą wartość");
                    liczba1 = Console.ReadLine();
                    if (double.TryParse(liczba1, out liczba1_) == false)
                    {
                        Console.WriteLine("Podałeś złe dane");
                    }
                    Console.WriteLine("Podaj drugą wartość");
                    liczba2 = Console.ReadLine();
                    if (double.TryParse(liczba2, out liczba2_) == false)
                    {
                        Console.WriteLine("Podałeś złe dane");
                    }
                    else
                        Console.WriteLine("Wynik wynosi: " + (liczba1_ - liczba2_));
                    break;

                case "3":
                    Console.WriteLine("Wpisz pierwszą wartość");
                    liczba1 = Console.ReadLine();
                    if (double.TryParse(liczba1, out liczba1_) == false)
                    {
                        Console.WriteLine("Podałeś złe dane");
                    }
                    Console.WriteLine("Podaj drugą wartość");
                    liczba2 = Console.ReadLine();
                    if (double.TryParse(liczba2, out liczba2_) == false)
                    {
                        Console.WriteLine("Podałeś złe dane");
                    }
                    else
                        Console.WriteLine("Wynik wynosi: " + (liczba1_ * liczba2_));
                    break;

                case "4":
                    Console.WriteLine("Wpisz pierwszą wartość");
                    liczba1 = Console.ReadLine();
                    if (double.TryParse(liczba1, out liczba1_) == false)
                    {
                        Console.WriteLine("Podałeś złe dane");
                    }
                    Console.WriteLine("Podaj drugą wartość");
                    liczba2 = Console.ReadLine();
                    if (double.TryParse(liczba2, out liczba2_) == false)
                    {
                        Console.WriteLine("Podałeś złe dane");
                    }
                    else
                        Console.WriteLine("Wynik wynosi: " + (liczba1_ / liczba2_));
                    break;
            }








            Console.ReadKey();

        }
    }
}