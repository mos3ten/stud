using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please,enter the text messagge and parameters for method:");
            string messagge = Console.ReadLine();
            stringOut(messagge);
        }
        static void stringOut(string messagge,params int[] List)
        {
             if (List.Length > 20)
                {
                    Console.WriteLine(messagge);
                }
                else Console.WriteLine("Sorry,but the total average of parameters is not enough. Its total average now is:{0}",List.Length);                
        }
    }
}
