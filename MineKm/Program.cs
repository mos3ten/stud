using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineKm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfKm;
            int numOfMeters;

            Console.WriteLine("Input the distance in kilometers: ");
            numOfKm = Convert.ToInt32 (Console.ReadLine());
            numOfMeters = numOfKm * 1000;
            Console.WriteLine("The distance in meters: " + numOfMeters);
            Console.ReadKey();

        }
    }
}
