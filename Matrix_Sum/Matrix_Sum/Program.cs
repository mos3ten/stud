using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix;
            int matrix_Size;
            Random rand = new Random();
            int sum_main=0;
            int sum_side = 0;
          
            Console.WriteLine("Please,enter the size of matrix.");
            matrix_Size = int.Parse(Console.ReadLine());
            matrix = new int[matrix_Size, matrix_Size];

            Console.WriteLine();

            for (int i = 0; i < matrix_Size; i++)
            {
                for (int j = 0; j < matrix_Size; j++)
                {
                    matrix[i, j] = rand.Next(1, 100);
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();

            for (int i = 0; i < matrix_Size; i++)
            {
                for(int j=0; j<matrix_Size;j++)
                {
                    Console.Write("{0}\t", matrix[i,j]);
                    sum_main += matrix[i,j];
                    i++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Main diagonal summary:{0}",sum_main);

            for (int i = matrix_Size - 1; i >=0; i--)
            {
                for (int j = 0; j <matrix_Size; j++)
                {
                    Console.Write("{0}\t",matrix[i,j]);
                    sum_side += matrix[i, j];
                    i--;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Side diagonal summary:{0}", sum_side);
            Console.ReadKey();
        }
    }
}
