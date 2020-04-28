using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sortowanie_liczb
{
    class Program
    {
        static void Sort(int[] tablica)  //algorytm sortowania
        {
            int n = tablica.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        int tmp = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];


            TextReader reader = File.OpenText(@"C:\Users\marco\source\repos\Sortowanie liczb\Sortowanie liczb\liczby.txt");
            {
                string strLine;
                while ((strLine = reader.ReadLine()) != null)
                {
                    string[] str = strLine.Split(','); // dzieli ciąg liczb na pojedyńcze, sugeruje się znakiem ','

                    int i = 0;

                    foreach (string s in str)
                    {
                        int.TryParse(s, out array[i]);
                        i++;
                    }

                }
            }

            using (StreamWriter wynik = new StreamWriter(@"WynikSortowania.txt", true))
            {

                wynik.WriteLine("Przed sortowaniem : \n");

                for (int z = 0; z < array.Length; z++)
                {
                    wynik.Write(array[z] + ", ");
                }

                Sort(array); // sortowanie liczb

                wynik.WriteLine("\n\nPo sortowaniu : \n");

                for (int z = 0; z < array.Length; z++)
                {
                    wynik.Write(array[z] + ", ");
                }
            }
                
        
        }
        
        

        
    }
}
