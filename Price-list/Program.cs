using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_list
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Begin program");
            HDD a = new HDD();
            //a.Print();
            Memory_carrier b = new SSD();
            //b.Print();
            Memory_carrier c = new DVD();
            c.Print();
        }
    }
}