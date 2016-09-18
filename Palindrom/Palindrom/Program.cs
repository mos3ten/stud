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
            string word;
            int i=0;
            
            Console.WriteLine("Please,enter the word:");
            word = Console.ReadLine();
            
            if (word[i] == word[word.Length - i-1] && word[i+1] == word[word.Length - i -2])
                {
                for (i = 0; i < word.Length; i++)
                {
                    Console.WriteLine(word[word.Length - i - 1]);
                }
                Console.WriteLine("Entered word is palindrom");
                }
          
            else
             {
                 Console.WriteLine("The enterde word isn't a palindrom");
             }

            Console.ReadKey();
        }
    }
}
