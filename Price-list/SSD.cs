using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_list
{
    internal class SSD : Memory_carrier
    {
        protected uint speed_usb;
        protected uint capacity;
        public SSD(string name_of_carrier, string name_of_manufacturer,
            string model, uint count, double price,
            uint speed_usb, uint capacity) : base(name_of_carrier, name_of_manufacturer, model, count, price)
        {
            this.Speed_usb = speed_usb;
            this.Capacity = capacity;
        }

        public SSD(uint speed_usb, uint capacity) : this("SeaGate", "Sillicon Power", "G512", 7, 2299.90, speed_usb, capacity) { }

        public SSD() : this("SeaGate", "Sillicon Power", "G512", 7, 1299.90, 4096, 1024) { }

        public override void Print()
        {
            Console.WriteLine("Type: SSD");
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

        public override void DownloadFile()
        {
            //base.DownloadFile();
            Console.Write("Download from SSD");
        }

        public override void SaveInFile()
        {
            //base.SaveInFile();
            Console.Write("Save in SSD");
        }
    }
}
