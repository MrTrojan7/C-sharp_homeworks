using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_list
{
    public abstract class Memory_carrier
    {
        protected string name_of_carrier;
        protected string name_of_manufacturer;
        protected string model;
        protected uint count;
        protected double price;

        public Memory_carrier(string name_of_carrier, string name_of_manufacturer, 
            string model, uint count, double price)
        {
            Name_of_carrier = name_of_carrier;
            Name_of_manufacturer = name_of_manufacturer;
            Model = model;
            Count = count;
            Price = price;
        }

        public virtual void Print()
        {
            Console.WriteLine("Name of carrier: " + Name_of_carrier);
            Console.WriteLine("Name of manufacturer " + Name_of_manufacturer);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Count: " + Count);
            Console.WriteLine("Price: " + Price);
        }

        public virtual void DownloadFile()
        {
            Console.WriteLine("Download from file (Memory carrier)");
        }
        public virtual void SaveInFile()
        {
            Console.WriteLine("Save in file (Memory carrier)");
        }

        public string Name_of_carrier
        {
            get { return name_of_carrier; }
            set { this.name_of_carrier = value; }
        }

        public string Name_of_manufacturer
        {
            get { return name_of_manufacturer; }
            set { this.name_of_manufacturer = value; }
        }

        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }

        public uint Count
        {
            get { return count; }
            set { this.count = value; }
        }

        public double Price
        {
            get { return price; }
            set { this.price = value; }
        }

    }
}
