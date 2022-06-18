using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_list
{
    public class HDD : Memory_carrier
    {
        protected uint speed_usb;
        protected uint capacity;
        public HDD(string name_of_carrier, string name_of_manufacturer,
            string model, uint count, double price, 
            uint speed_usb, uint capacity) : base(name_of_carrier, name_of_manufacturer, model, count, price)
        {
            this.Speed_usb = speed_usb;
            this.Capacity = capacity;
        }

        public HDD(uint speed_usb, uint capacity) : this("TRON", "Kingston", "F256", 5, 520.10, speed_usb, capacity) { }

        public HDD() : this("TRON", "Kingston", "F256", 5, 520.10, 384, 256) { }

        public override void Print()
        {
            Console.WriteLine("Type: HDD");
            base.Print();
            Console.WriteLine("USB Speed: " + this.Speed_usb);
            Console.WriteLine("Capacity: " + this.Capacity);
        }

        public uint Speed_usb
        {
            get { return speed_usb; }
            set { this.speed_usb = value; }
        }
        
        public uint Capacity
        {
            get { return capacity; }
            set { this.capacity = value; }
        }
    }
}
