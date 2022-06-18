using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_list
{
    internal class DVD : Memory_carrier
    {
        protected uint reading_speed;
        protected uint writing_speed;
        public DVD(string name_of_carrier, string name_of_manufacturer,
            string model, uint count, double price,
            uint reading_speed, uint writing_speed) : base(name_of_carrier, name_of_manufacturer, model, count, price)
        {
            this.Reading_speed = reading_speed;
            this.Writing_speed = writing_speed;
        }

        public DVD(uint reading_speed, uint writing_speed)
            : this("BlueRayVision", "Data Life", "RW-4.7", 7, 19.90, reading_speed, writing_speed) { }

        public DVD() : this("BlueRayVision", "Data Life", "RW-4.7", 10, 19.90, 5200, 1700) { }

        public override void Print()
        {
            Console.WriteLine("Type: DVD");
            base.Print();
            Console.WriteLine("Reading speed: " + this.Reading_speed);
            Console.WriteLine("Writing speed: " + this.Writing_speed);
        }

        public uint Reading_speed
        {
            get { return reading_speed; }
            set { this.reading_speed = value; }
        }

        public uint Writing_speed
        {
            get { return writing_speed; }
            set { this.writing_speed = value; }
        }

        public override void DownloadFile()
        {
            //base.DownloadFile();
            Console.Write("Download from DVD");
        }

        public override void SaveInFile()
        {
            //base.SaveInFile();
            Console.Write("Save in DVD");
        }
    }
}
