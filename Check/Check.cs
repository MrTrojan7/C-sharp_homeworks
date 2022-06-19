using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    struct Check
    {
        private static uint number_of_check = 0;
        private List<Product> products;
        private double total = 0;
        //private string foresight;

        public Check(Product[] arr)
        {
            this.products = new List<Product>();
            for (int i = 0; i < arr.Length; i++)
            {
                products.Add(arr[i]);
            }
        }

        public void Print()
        {
            Console.WriteLine("Silpo");
            Console.WriteLine("Check # " + number_of_check++);
            Console.WriteLine("Date&Time" + DateTime.Now);
            Console.WriteLine("List of products: ");
            Console.WriteLine("======================");
            for (int i = 0; i < this.products.Count; i++)
            {
                this.products[i].PrintProduct();
                this.total += this.products[i].Final_price;
            }
            Console.WriteLine("======================");
            Console.WriteLine("to pay: " + this.total);
            Console.WriteLine("Have a nice day! Slava Ukraini!");
            Console.WriteLine();
            this.total = 0;
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void AddProduct(string name, int count, int price, double discount)
        {
            this.AddProduct(new Product(name, count, price, discount));
        }
    }
}
