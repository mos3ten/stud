using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
                        
            Console.WriteLine("Please,enter a number of runners: ");
            num = int.Parse(Console.ReadLine());

            Runner[] newRunner = new Runner[num];

            for (int i = 0; i < num; i++)
            {
                newRunner[i] = new Runner();
                newRunner[i].PIB = Console.ReadLine();
                newRunner[i].Time = float.Parse(Console.ReadLine());
            }

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(newRunner[i].PIB,newRunner[i].Time);  
            }
            
        }
    }
}
