using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_list
{
    public class App
    {
        static Random rnd = new Random();
        private List<Memory_carrier> arr;
        private int countOfDevices;
        public App(int count)
        {
            this.CountOfDevices = count;
            arr = new List<Memory_carrier>(CountOfDevices);
            for (int i = 0; i < CountOfDevices; i++)
            {
                if (rnd.Next(1, 4) == 1)
                    arr.Add(new DVD());
                else if (rnd.Next(1, 4) == 2)
                    arr.Add(new HDD());
                else
                    arr.Add(new SSD());
            }
        }
        public App() : this(3) { }

        public int CountOfDevices
        {
            get { return countOfDevices; }
            set { countOfDevices = value; }
        }

        public void ChangeInfo(double price, int index)
        {
            arr[index].Price = price;
        }

        public void PrintList()
        {
            for (int i = 0; i < this.CountOfDevices; i++)
            {
                arr[i].Print();
                Console.WriteLine("---------------");
            }
        }

        public void AddCarrier(ref Memory_carrier memory_carrier)
        {
            arr.Add(memory_carrier);
            ++countOfDevices;
        }

        public void DeleteMinPrice()
        {
            int index = 0;
            double min_price = arr[0].Price;
            for (int i = 0; i < this.CountOfDevices; i++)
            {
                if (arr[i].Price >= min_price)
                    ++index;
            }
            arr.RemoveAt(index);
        }

        public void DeleteByPrice(int min_price)
        {
            for (int i = 0; i < this.CountOfDevices; i++)
            {
                if (arr[i].Price >= min_price)
                    arr.RemoveAt(i);
            }
        }

        public void DeleteByCount()
        {
            int index = 0;
            int min_price = (int)arr[0].Count;
            for (int i = 0; i < this.CountOfDevices; i++)
            {
                if (arr[i].Price >= min_price)
                    ++index;
            }
            arr.RemoveAt(index);
        }

        public void SearchByName(string name)
        {
            int count = 0;
            Console.WriteLine("Devices with name " + name);
            for (int i = 0; i < this.CountOfDevices; i++)
            {

                if (arr[i].Name_of_manufacturer == name)
                {
                    arr[i].Print();
                    count++;
                }

            }
            if (count == 0) Console.WriteLine(" not found");
        }
        public void SearchByMinPrice(int min_price)
        {
            int count = 0;
            Console.Write("\nDevices with price " + min_price);
            for (int i = 0; i < this.CountOfDevices; i++)
            {

                if (arr[i].Price >= min_price)
                {
                    Console.WriteLine();
                    arr[i].Print();
                    count++;
                }

            }
            if (count == 0) Console.WriteLine(" not found");
        }
    }
}
