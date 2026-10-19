using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР6._2
{
    internal class StudentAgeComparer : IComparer<Student>
    {
        public int Compare(Student a, Student b)
        {
            return a.Age.CompareTo(b.Age);
        }
    }
}
