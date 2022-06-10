using System;

namespace LaptopShop
{
    class Shop
    {
        string name;
        Laptop[] arr;

        public Shop(string name, int count)
        {
            this.Name = name;
            arr = new Laptop[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = new Laptop();
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Laptop this[int index]
        {
            get
            {
                if (index < 0 || index >= arr.Length)
                {
                    return arr[0];
                }
                else
                {
                    return arr[index];
                }
            }
            set
            {
                arr[index] = value;
            }
        }
        public Shop() : this("Citrus", 10) { }
        public Shop(int count) : this("Citrus", count) { }
        public Shop(Laptop[] array) : this("Citrus", array.Length)
        {
        
           for (int i = 0; i < array.Length; i++)
           {
               arr[i] = array[i];
           }
        }
        public void ShowShop()
        {
            Console.WriteLine("Name of shop: " + this.Name);
            Console.WriteLine("models of Laptops: \n");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].PrintLaptop();
            }
        }
    }
}