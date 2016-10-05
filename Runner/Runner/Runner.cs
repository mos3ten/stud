using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Runner
    {
        private string pib;
        private float time;

        public string PIB
        {
            get
            {
                return pib;
            }
            set
            {
                pib = Console.ReadLine();
            }
        }
        public float Time
        {
            get
            {
                return time;
            }
            set
            {
                time = float.Parse(Console.ReadLine());
            }
        }

        public Runner(string pib = "Unknown",float time = 0f)
        {
            PIB = pib;
            Time = time;
        }

   /*     public void ShowInfo()
        {
            Console.WriteLine("\n Runner Name: {0} \nRunner Time:{1}",PIB,Time);
            Console.WriteLine("\n");
        }
        */
    }
}
