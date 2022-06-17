using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace StudentGroup
{
    // Comparer 
    class SortBySurname : IComparer<Student>
    {
        public int Compare(Student first, Student second)
        {
            return String.Compare(first.Surname, second.Surname);
        }
    }
    class SortByAge : IComparer<Student>
    {
        public int Compare(Student first, Student second)
        {
            return DateTime.Compare(first.Date_of_birth, second.Date_of_birth);
        }
    }
}
