using System;

namespace Stairs
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Input quantity of stairs: ");
            int n = Convert.ToInt32(System.Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int spaces = 2 * i;
                for (int j = 0; j < spaces; j++)
                    Console.Write(' ');
                Console.WriteLine("***");
                spaces = 2 * (i + 1);
                for (int j = 0; j < spaces; j++)
                    Console.Write(' ');
                Console.WriteLine("*");
            }
        }
    }
}