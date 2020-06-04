using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Bubble
    {
        public static void BubbleSort(int[] tbl)
        {
            int counter = tbl.Length;

            for (int i = 0; i < counter; i++)
                for (int j = 0; j < counter - 1 - i; j++)
                {
                    if (tbl[j] > tbl[j + 1])
                    {
                        int pom = tbl[j];
                        tbl[j] = tbl[j + 1];
                        tbl[j + 1] = pom;
                    }
                }
        }

        public static void Main(string[] args)
        {
            int counter = 0;
            int[] tbl = new int[1000];
            StreamReader file1 = new StreamReader(@"dane2.txt");

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


            using (StreamWriter file2 = new StreamWriter(@"dane2_.txt", true))
            {
                file2.WriteLine("Przed sortowaniem : \n");
                for (int i = 0; i < counter; i++)
                {
                    file2.Write(tbl[i] + ", ");
                }
                file2.WriteLine("\n");

                BubbleSort(tbl); // sort

                file2.WriteLine("Po sortowaniu : \n");

                for (int z = 0; z < counter; z++)
                {
                    file2.Write(tbl[z] + ", ");
                }
            }


        }
    }
}
