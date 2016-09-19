using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance;
            string day_time;
            const int taxi_Call= 30;
            const double price_1 = 5;
            const double price_2 = 4;
            const double price_3 = 3;
            double total_Price=0;

            Console.WriteLine("Please,enter the day time night/day: ");
            day_time = Console.ReadLine();
            Console.WriteLine("Please,enter the distance:");
            distance = Double.Parse(Console.ReadLine());
           
                      
            switch (day_time)
                {
                case "day":
                    if (distance < 10)
                    {
                        total_Price = taxi_Call + (distance * price_1);
                    }
                    if (distance > 10)
                    {
                        total_Price = taxi_Call + (distance * price_2);
                    }

                    if (distance > 20)
                    {
                        total_Price = taxi_Call + (distance * price_3);
                    }
                    Console.WriteLine("Total price of service:{0}", total_Price);
                    break;


                case "night":
                    if (distance < 10)
                    {
                        total_Price = (taxi_Call + (distance * price_1)) / 2;
                    }
                    if (distance > 10)
                    {
                        total_Price = (taxi_Call + (distance * price_2)) / 2;
                    }

                    if (distance > 20)
                    {
                        total_Price = (taxi_Call + (distance * price_3))/2;
                    }
                    Console.WriteLine("Total price of service:{0}", total_Price);
                    break;

            }
        }
    }
}
