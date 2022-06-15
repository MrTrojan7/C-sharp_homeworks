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
            
            DateTime dt = new DateTime(2000, 10, 10);
            DateTime dt2 = new DateTime(2001, 1, 1);
            if (dt > dt2)
            {
                //Console.WriteLine("true");
            }
            Student a = new Student("Petrow", "Yurij", "Yurijovych", dt, "Chernyahovskogo 3", 2322123);
            a.ShowStudent();
            Student b = new Student("Alan");
            b.ShowStudent();
        }
    }
}
