using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array;
            int r;
            int l;

            int[] array_1;
            int n;
            int k = 0;
            Random rand = new Random();

            Console.WriteLine("Please,enter the number for search in array:");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease,enter the number of elements in array:");
            n = int.Parse(Console.ReadLine());
            array_1 = new int[n];
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                array_1[i] = rand.Next(0, 100);
                Console.WriteLine(array_1[i]);
            }
            return_Index(array_1, k);

            Console.WriteLine("Please,enter the number of rows of array:");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("Please,enter the number of columns of array:");
            l = int.Parse(Console.ReadLine());
            array = new int[r, l];
            Console.WriteLine();
            fillTheArray(r, l, ref array);
            Console.WriteLine("Array in Main:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    Console.Write("{0,3}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            
        }

        static int return_Index(int[]array, int n)
        {
            for (int i = 0; i< array.Length; i++)
            {
                if (array[i] == n)
                {
                    Console.WriteLine("Your index in array:{0}\n",i);
                    return i;
                }
            }
            Console.WriteLine("\n-1");
            return -1;
        }

        static int fillTheArray(int r, int l, ref int[,] array)
        {
            Random rand = new Random();

            array = new int[r, l];

            Console.WriteLine("Array in Method:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    array[i, j] = rand.Next(0, r * l);
                    Console.Write("{0,3}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            return 0;
        }

    }

}
