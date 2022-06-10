using System;

namespace LaptopShop
{
    public class Laptop
    {
        private string name;
        private string manufacturer;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = IsValidName(value); }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = IsValidManufacturer(value); }
        }
        public Laptop(string name, string manufacturer, double price)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Price must be more than 0!");
                    Environment.Exit(0);
                }
            }
        }
        public Laptop()
        {
            this.Name = "Legion";
            this.Manufacturer = "Lenovo";
            this.Price = 29999.90;
        }

        public Laptop(string name) : this(name, "Lenovo", 29999.90) { }
        public Laptop(string name, string manufacturer) : this(name, manufacturer, 29999.90) { }
        public Laptop(string name, double price) : this(name, "Lenovo", price) { }
        //public Laptop(string manufacturer, double price) : this("Legion", manufacturer, price) { }
        public Laptop(double price) : this("Legion", "Lenovo", price) { }

        private string IsValidName(string str)
        {
            if (str != "")
                return str;
            else
                return "MacBook AirPro";
        }
        private string IsValidManufacturer(string str)
        {
            if (str != "")
                return str;
            else
                return "Apple";
        }
        public void PrintLaptop()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Manufacturer: " + this.manufacturer);
            Console.WriteLine("Price: " + this.price + "\n");
        }
    }
}