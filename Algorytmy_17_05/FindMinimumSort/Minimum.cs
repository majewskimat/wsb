using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinimumSort
{
    class Minimum
    {
        public static void FindMinimumSort(int[] tbl)
        {
            int counter = tbl.Length - 1;

            for (int i = 0; i < counter; i++)
            {
                int maxmin = tbl[0];
                int pozmaxmin = 0;
                for (int j = 0; j < counter - i; j++)
                {
                    if (tbl[j] > maxmin)
                    {
                        maxmin = tbl[j];
                        pozmaxmin = j;
                    }
                }
                int pom = tbl[counter - i];
                tbl[counter - i] = tbl[pozmaxmin];
                tbl[pozmaxmin] = pom;
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


            using (StreamWriter file2 = new StreamWriter(@"dane1_.txt", true))
            {
                file2.WriteLine("Przed sortowaniem : \n");
                for (int i = 0; i < counter; i++)
                {
                    file2.Write(tbl[i] + ", ");
                }
                file2.WriteLine("\n");

                FindMinimumSort(tbl); // sort

                file2.WriteLine("Po sortowaniu : \n");

                for (int z = 0; z < counter; z++)
                {
                    file2.Write(tbl[z] + ", ");
                }
            }


        }
    }
}
