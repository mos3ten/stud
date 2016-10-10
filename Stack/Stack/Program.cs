using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack_Even();
            Queue_Check();
        }

        static void Queue_Check()
        {
            string test_w = "if";
            string wordset;
            int q_size;
            int counter = 0;


            Console.WriteLine("Please,enter the size of queue:");
            q_size = int.Parse(Console.ReadLine());
            Queue<string> myQuery = new Queue<string>(q_size);

            Console.WriteLine("Please,enter the set of words. Each every from a new line:");
            for (int i = 0; i < q_size; i++)
            {
                myQuery.Enqueue(Console.ReadLine());
            }

            if (myQuery.Contains(test_w))
            {
                for (int i = 0; i < myQuery.Count; i++)
                {
                    if (myQuery.ElementAt(i) == test_w)
                    {
                        counter += 1;
                    }

                }

            }

            Console.WriteLine("\nQueue:");
            while (myQuery.Count > 0)
            {
                Console.WriteLine(myQuery.Dequeue());
            }
            Console.WriteLine("Number of 'if' in queue is {0}", counter);
        }

        static void Stack_Even()
        {
            string line;
            char[] array;
            int temp = 0;
            Stack<char> myStack = new Stack<char>();

            Console.WriteLine("Please,enter your symbols: ");
            line = Console.ReadLine();

            array = line.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                myStack.Push(array[i]);
            }

            


            if (myStack.Contains('1'))
            {
                while (myStack.Count > 0)
                {
                    if (myStack.Pop() == '1')
                    {
                        temp += 1;
                    }
                }
                if (temp % 2 == 0)
                {
                    Console.WriteLine("Quantity of 1 is even");
                }
                else
                {
                    Console.WriteLine("Quantity of 1 not even");
                }
            }
            
            else
               {
                   Console.WriteLine("There are no any fucking '1' in your set. Go to sleep!!!!!");
               }
        }
    }     
}
