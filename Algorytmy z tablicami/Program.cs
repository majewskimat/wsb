using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy_z_tablicami
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = { 1, 3, 5, 1, 2, 1, 3 };
            Console.WriteLine("Tab1");
            wlasciwosci(tab1);
            int[] tab2 = { 1, 3, 3, 6, 3, 2, 1 };
            Console.WriteLine("Tab2");
            wlasciwosci(tab2);
            int[] tab3 = { };
            Console.WriteLine("Tab3");
            wlasciwosci(tab3);

            Console.ReadLine();
        }

        static void wlasciwosci(int[] tab)
        {
            Console.WriteLine("SUMA: ");
            Console.WriteLine(sumaElementow(tab));
            Console.WriteLine("MIN: ");
            Console.WriteLine(min(tab));
            Console.WriteLine("MAX: ");
            Console.WriteLine(max(tab));
            Console.WriteLine("DOMINANTA: ");
            Console.WriteLine(dominanta(tab));
            Console.WriteLine("ILE WYSTĄPIEŃ 3: ");
            Console.WriteLine(ileWystapien(tab, 3));
        }

        static int sumaElementow(int[] tab)
        {
            int suma = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma += tab[i];
            }
            return suma;
        }
        static int min(int[] tab)
        {
            if (tab.Length == 0)
            {
                return 0;
            }
            int minimum = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] < minimum)
                {
                    minimum = tab[i];
                }

            }
            return minimum;

        }

        static int max(int[] tab)
        {
            if (tab.Length == 0)
            {
                return 0;
            }
            int maximum = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > maximum)
                {
                    maximum = tab[i];
                }
            }
            return maximum;
        }
        static int dominanta(int[] tab)
        {
            if (tab.Length == 0)
            {
                return 0;
            }
            int minimum = min(tab);
            int maximum = max(tab);
            int[] pomocnicza = new int[maximum - minimum + 1];
            for (int i = 0; i < tab.Length; i++)
            {
                pomocnicza[tab[i] - minimum]++;
            }
            int wystapienia = max(pomocnicza);
            int wynik = 0;
            for (int i = 0; i < pomocnicza.Length; i++)
            {
                if (pomocnicza[i] == wystapienia)
                {
                    return i + minimum;
                } 
            }
            return wynik;
        }

        static int ileWystapien(int[] tab, int liczba)
        {
            int ile = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == liczba)
                {
                    ile++;
                }
            }
            return ile;
        }
        
    }
}
