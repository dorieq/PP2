using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace classstudent
{
    class Student
    {
        string name;
        string sname;
        double gpa;
        public Student(string n, string s, double g)
        {
            name = n;
            sname = s;
            gpa = g;
        }
        public void ReadInfo()
        {
            name = Console.ReadLine();
            sname = Console.ReadLine();
            gpa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return this.sname + " " + this.name + " " + this.gpa;
        }
    }
    class Program
    {
        static int Main(string[] args)
        {
            Random R = new Random();
            int a = R.Next(1, 10);
            if (a >= 5)
            {
                Student s = new Student("Derbes", "Utebaliyev", 3.33);
                Console.WriteLine(s);
                    }
            else
            {
                Student s = new Student(Console.ReadLine(), Console.ReadLine(), double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine(s);
            }
            return 0;
        }
    }
}
