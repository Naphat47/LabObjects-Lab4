using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Encapsulatiom
{
    public class Person
    {
        public string name { get; set; }
        public double gpa { get; set; }
        public int birthYear { get; set; }

        public Person(string name, int bYear, double gpa)
        {
            this.name = name;
            this.gpa = gpa;
            this.birthYear = 2566 - bYear;
        }
    }
}
