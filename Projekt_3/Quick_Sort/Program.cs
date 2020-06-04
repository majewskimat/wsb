using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    class Program
    {
        public static void QuickSort(int[] array, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = array[(left + right) / 2];
            while (i < j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;
                if (i <= j)
                {
                    // swap
                    var tmp = array[i];
                    array[i++] = array[j];  // ++ and -- inside array braces for shorter code
                    array[j--] = tmp;
                }
            }
            if (left < j) QuickSort(array, left, j);
            if (i < right) QuickSort(array, i, right);
        }

        static void Main(string[] args)
        {
            var rand = new Random();
            var array = new int[10000];
            for (int i = 0; i < array.Length; i++)
            {
                // array[i] = rand.Next(10000); LOSOWE
            }
            Console.WriteLine("Before: ");
            Console.WriteLine(string.Join(" ", array));

            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine("Affter: ");
            Console.WriteLine(string.Join(" ", array));

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
