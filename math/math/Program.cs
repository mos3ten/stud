using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            double l;
            double r;
            float a;
            float b;
            float c;
            float d;

            Console.WriteLine("Please, enter the radius of circle:");

            r = double.Parse(Console.ReadLine());

            Console.WriteLine("Please,enter three numbers. Each new from a new line.");

            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());

            l = r*(2 * 3.14);

            d = (a + b + c) / 3;

            Console.WriteLine("The circumference is {0}",l);
            Console.WriteLine("The middle ariphmetic is {0}",d);

            Console.ReadKey();
            

        }
    }
}
