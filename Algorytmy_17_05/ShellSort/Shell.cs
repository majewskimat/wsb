using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{

    class Shell
    {
        static void ShellSort(int[] tab)
        {
            int counter = tab.Length / 2;
            while (counter >= 1)
            {
                for (int i = counter; i < tab.Length; i += 1)
                {
                    int temp = tab[i];
                    int j;
                    for (j = i; j >= counter && tab[j - counter] > temp; j -= counter)
                        tab[j] = tab[j - counter];
                    tab[j] = temp;
                }
                counter /= 2;
            }
        }
        static void Main(string[] args)
        {
            int counter = 0;
            int[] tbl = new int[1000];
            StreamReader file1 = new StreamReader(@"dane1.txt");

            string line;

            while ((line = file1.ReadLine()) != null)
            {
                string[] stbl = line.Split(' ');


                foreach (string l in stbl)
                {
                    int.TryParse(l, out tbl[counter]);
                    counter++;
                }
            }


            //==============================================================================


            using (StreamWriter file2 = new StreamWriter(@"Shelldane1_.txt", true))
            {
                file2.WriteLine("Przed sortowaniem : \n");
                for (int i = 0; i < counter; i++)
                {
                    file2.Write(tbl[i] + ", ");
                }
                file2.WriteLine("\n");

                ShellSort(tbl); // sort

                file2.WriteLine("Po sortowaniu : \n");

                for (int z = 0; z < counter; z++)
                {
                    file2.Write(tbl[z] + ", ");
                }
            }


        }
    }
}
