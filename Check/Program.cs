using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    class Program
    {
        public static void Main()
        {
            Product a = new Product("Kovbasa", 2, 40, 10);
            Product b = new Product("Sik", 1, 80, 10);
            Product c = new Product("Vyshniak", 5, 100, 5);
            Product d = new Product("Borshch", 2, 10, 0);
            Product e = new Product("Hlib", 2, 20, 5);
            Product f = new Product("Moloko", 4, 30, 0);
            //a.PrintProduct();
            Product[] arr = new Product[] { a, b, c, d, e };
            Check check = new Check(arr);
            check.Print();
            check.AddProduct(f);
            Console.WriteLine("\nAdd product\n");
            check.Print();
            check.AddProduct("Voda", 3, 10, 0);
            Console.WriteLine("\nAdd new product\n");
            check.Print();
        }
    }
}