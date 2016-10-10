using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ink
{
    class Student
    {
        private string pib;
        private string adress;
        private Collection <double> marks;
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

        public Collection<double> Marks
        {
            get
                {
                    return marks;
                }
            set
            {
                marks = value;
            }
        }
        

        public Student(string PIB = "Unknown",string Adress = "Unknown", double[] marks = 0d)
        {
            PIB = pib;
            Adress = adress;
            Marks = new Collection<double>(marks);

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
