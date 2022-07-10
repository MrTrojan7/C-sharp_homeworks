using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalization
{
    class Program
    {
        static void Main()
        {
            Point<int> a = new Point<int>();
            Point<double> b = new Point<double>(1.1, 2.2, 3.3);
            a.Print();
            b.Print();
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++) { arr[i] = i; }
            PrintArray.Print_Array(ref arr);

        }
    }
}