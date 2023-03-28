using System;
using System.Drawing.Design;
using System.Xml.Linq;

namespace Lab4_Encapsulatiom
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string bYear = tbBirthYear.Text;
            string gpa = tbGrade.Text;
            int ibYear = Int32.Parse(bYear);
            double iGpa = double.Parse(gpa);
            Person newStudent = new Person(name, ibYear, iGpa);

            this.classroom.addPersonToClass(newStudent);
            this.classroom.addGPAToClass();
            this.tbListofPerson.Text = this.classroom.showAllPersoninClass();

            int currentAge = Int32.Parse(this.tbGrade.Text);
            int newTotal = currentAge + this.classroom.showTotalAgeinClass();
            this.tbTotal.Text = newTotal.ToString();

            double newMax = this.classroom.showGPXMax();
            this.tbMax.Text = newMax.ToString();

            double newMin = this.classroom.showGPXMin();
            this.tbMin.Text = newMin.ToString();

            double newAvg = this.classroom.showGPXAvg();
            this.tbAvg.Text = newAvg.ToString();

            this.tbNameMax.Text = this.classroom.showNameMax();
            this.tbNameMin.Text = this.classroom.showNameMin();

            this.tbName.Text = "";
            this.tbBirthYear.Text = "";
            this.tbGrade.Text = "";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}