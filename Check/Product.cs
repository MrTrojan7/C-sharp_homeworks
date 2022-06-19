using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    struct Product
    {
        private string name;
        private int count;
        private int price;
        private double discount;
        private double final_price;
        public Product(string name, int count, int price, double discount)
        {
            this.name = name;
            this.count = count;
            this.price = price;
            this.discount = discount;
            this.final_price = (price - price * (discount / 100)) * count;
            CheckInfo(count, price, discount);
        }
        public double Final_price
        {
            get { return final_price; }
        }

        private void CheckInfo(int count, int price, double discount)
        {
            try
            {
                if (count < 0 || price <= 0 || (discount < 0 || discount > 100))
                    throw new ArgumentOutOfRangeException();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Exception! Incorrect value (count, price or discount)!");
                Environment.Exit(0);
            }
        }
        public void PrintProduct()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Product name: " + this.name);
            Console.WriteLine("Count: " + this.count);
            Console.WriteLine("Price: " + this.price);
            Console.WriteLine("Discount: " + this.discount);
            Console.WriteLine("Final price: " + this.Final_price);
        }
    }
}
