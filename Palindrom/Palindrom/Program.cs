using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string test_array;
            Console.WriteLine("Please, enter a testing word or sentense.");
            test_array = Console.ReadLine();

            if (isPalindrome(test_array) == true)
            {
                Console.WriteLine("The testing text\n '{0}'\n is palindrome", test_array);
            }
            else
            {
                Console.WriteLine("The testing text\n '{0}'\n isn't palindrome", test_array);
            }
            Console.ReadKey();

         }

        public static bool isPalindrome(string test_array)
        {
            int min = 0;
            int max = test_array.Length - 1;

            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = test_array[min];
                char b = test_array[max];

                while (!char.IsLetterOrDigit(a))
                {
                    min++;
                    if (min > max)
                    {
                        return true;
                    }
                    a = test_array[min];
                }

                while (!char.IsLetterOrDigit(b))
                {
                    max--;
                    if (min > max)
                    {
                        return true;
                    }
                    b = test_array[max];
                }
                if (char.ToLower(a) != char.ToLower(b))
                {
                   return false;
                }
                min++;
                max--;
            }
        }
    }
}
    
