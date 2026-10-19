using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР6._2
{
    internal class Student : IComparable<Student>
    {
        private string _name;
        private int _age;
        private double _gpa;

        public Student(string name, int age, double gpa)
        {
            this.Name = name;
            this.Age = age;
            this.Gpa = gpa;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public int CompareTo(Student other)
        {
            return _age.CompareTo(other.Age);
        }
    }


}
