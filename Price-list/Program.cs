﻿using System;
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
            HDD a = new HDD();
            //a.Print();
            Memory_carrier b = new SSD();
            //b.Print();
            Memory_carrier c = new DVD();
            //c.Print();
            //c.DownloadFile();
            App d = new App();
            //d.PrintList();
            //d.AddCarrier(ref a); no
            d.AddCarrier(ref b);
            d.AddCarrier(ref c);
            d.ChangeInfo(999999, 2);
            d.PrintList();
        }
    }
}