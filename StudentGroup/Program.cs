using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace StudentGroup
{
    class Program
    {
        static void Main()
        {
            Student b = new Student("Alan");
            b.AddCourseWorks(12);
            //b.ShowStudent();

            Group a = new Group(10);
            a.ShowGroup();
            a.Remove();
            //a.ShowGroup();
            a.AddStudent(ref b);
            //a.ShowGroup();
            a.Remove();
            a.Remove();
            a.Remove();
            a.ShowGroup();
            a[2].ShowStudent();
        }
    }
}
