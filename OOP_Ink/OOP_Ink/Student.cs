using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ink
{
    class Student
    {
        private string pib;
        private string adress;
        private Double[] marks;
        private double avg_mark;

        public string PIB
        {
            get { return pib; }
            set { pib = Console.ReadLine(); }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = Console.ReadLine(); }
        }

        public double Marks
        {
            get
            {
                for (int i = 0; i < marks.Length; i++)
                {
                    return marks[i];
                }
            }
            set
            {
                for (int i = 0; i < marks.Length; i++)
                {
                    marks[i]= double.Parse(Console.ReadLine());
                }
            }
        }
        

        public Student(string PIB = "Unknown",string Adress = "Unknown", double Marks = 0d)
        {
            PIB = pib;
            Adress = adress;
            Marks = marks;

        }

        public double CalculateAvg(double[] marks )
        {
            double AVG;
            double temp = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                temp += marks[i];
            }
             AVG = temp / marks.Length;
             return AVG;
        }

    }
}
