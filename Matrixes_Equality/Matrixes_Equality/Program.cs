using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixes_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix_1;
            int[,] matrix_2;
            int matrix_Size;
            decimal counter = 0;
            decimal equality = 0;

            Random rand = new Random();

            Console.WriteLine("Please,enter the size of natrix");
            matrix_Size = int.Parse(Console.ReadLine());

            matrix_1 = new int [matrix_Size,matrix_Size];
            matrix_2 = new int[matrix_Size, matrix_Size];
          
           
            

            for (int i = 0; i < matrix_Size; i++)
            {
                for (int j = 0; j < matrix_Size; j++)
                {
                    matrix_1[i, j] = rand.Next(0, 10);
                    Console.Write("{0}\t", matrix_1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Length matrix 1:{0} ", matrix_1.Length);

            for (int i = 0; i < matrix_Size; i++)
            {
                for (int j = 0; j < matrix_Size; j++)
                {
                    matrix_2[i, j] = rand.Next(0, 10);
                    Console.Write("{0}\t", matrix_2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Length matrix 2:{0} ", matrix_2.Length);

                       for (int i = 0; i < matrix_Size; i++)
                       {
                           for (int j = 0; j < matrix_Size; j++)
                           {
                             if (matrix_1[i, j] == matrix_2[i, j] && i < matrix_Size && j < matrix_Size)
                                {
                                 counter = counter+1;
                                }
                           }
                       }
            equality = (counter/Convert.ToDecimal(matrix_1.Length))*100;
            Console.WriteLine("Equality {0}%", equality);
            Console.ReadKey();

        }

    }
}
