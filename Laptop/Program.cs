using System;

namespace LaptopShop
{
    class Program
    {
        static void Main()
        {
            Shop shop = new("Privoz", 5);
            shop[0] = new Laptop("Threadripper", "Ryzen", 1000000);
            shop[1] = new Laptop("Asus", "tsmc", 20000);
            shop[2] = new Laptop("Acer", "smth", 25000);
            shop[3] = new Laptop("", "", 25000);
            shop[4] = new Laptop(100);
            shop[0].PrintLaptop();
            shop[1].PrintLaptop();
            shop[2].PrintLaptop();
            shop[3].PrintLaptop();
            shop[4].PrintLaptop();
            Console.WriteLine("+++++++++++++++++++++++++++++++++\n");
            shop.ShowShop();
        }
    }
}