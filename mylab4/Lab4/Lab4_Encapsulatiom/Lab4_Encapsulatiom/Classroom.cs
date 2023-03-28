using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Encapsulatiom
{
    public class Classroom
    {
        private string name;
        private List<Person> persons = new List<Person>(); //array <-> list
        private List<double> GPAs = new List<double>(); //Add
        private List<string> names = new List<string>(); //Ad
        public Classroom(string name)
        {
            this.name = name;
        }
        public void addPersonToClass(Person p)
        {
            this.persons.Add(p);
        }
        public string showAllPersoninClass()
        {
            string result = "";
            foreach (var student in this.persons)
            {
                result += student.name + "\t" + student.gpa + "\r\n";
            }
            return result;
        }
        public void addGPAToClass()
        {
            foreach (var student in persons)
            {
                GPAs.Add(student.gpa);
                names.Add(student.name);
            }
        }
        public int showTotalAgeinClass()
        {
            int Result = 0;
            foreach (var student in this.persons)
            {
                Result = student.birthYear;
            }
            return Result;
        }

        public double showGPXMax()
        {
            double max = GPAs.Max();
            return max;
        }

        public double showGPXMin()
        {
            double min = GPAs.Min();
            return min;
        }

        public double showGPXAvg()
        {
            double avg = GPAs.Average();
            return avg;
        }

        public string showNameMax()
        {
            return names[GPAs.IndexOf(GPAs.Max())];
        }

        public string showNameMin()
        {
            return names[GPAs.IndexOf(GPAs.Min())];
        }
    }
}
