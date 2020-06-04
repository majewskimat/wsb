using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumSort
{
    class Maximum
    {
        public static void FindMaximumSort(int[] tbl)
        {
            int counter = tbl.Length;

            for (int i = 0; i < counter; i++)
            {
                int maxmin = tbl[i]; 
                int pozmaxmin = i;
                for (int j = i+1; j < counter; j++)
                {
                    if (tbl[j] < maxmin)
                    {
                        maxmin = tbl[j];
                        pozmaxmin = j;
                    }
                }
                int pom = tbl[i];
                tbl[i] = tbl[pozmaxmin];
                tbl[pozmaxmin] = pom;
            }
        }
        static void Main(string[] args)
        {
            int counter = 0;
            int[] tbl = new int[1000];
            StreamReader file1 = new StreamReader(@"dane3.txt");

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


            using (StreamWriter file2 = new StreamWriter(@"dane3_.txt", true))
            {
                file2.WriteLine("Przed sortowaniem : \n");
                for (int i = 0; i < counter; i++)
                {
                    file2.Write(tbl[i] + ", ");
                }
                file2.WriteLine("\n");

                FindMaximumSort(tbl); // sort

                file2.WriteLine("Po sortowaniu : \n");

                for (int z = 0; z < counter; z++)
                {
                    file2.Write(tbl[z] + ", ");
                }
            }


        }
    }
}
