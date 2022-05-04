using System;

namespace Spiral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght:");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter height");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] arr2 = new int[M, N];
            int z;
            int k = 0;
            int x = 0;
            int y = 0;
            int iter = 0;
            for (z = 1; z <= M * N; z++)
            {
                arr2[x, y] = z;
                switch (k % 4)
                {
                    case 0:
                        y++;
                        if (y == (N - x - 1))
                            k++;
                        break;
                    case 1:
                        x++;
                        if (x == (M - 1 - iter))
                            k++;
                        break;
                    case 2:
                        y--;
                        if (y == (N - N + iter))
                            k++;
                        break;
                    case 3:
                        x--;
                        if (x == (M - M + iter + 1))
                        {
                            iter++;
                            k++;
                        }
                        break;
                }
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(arr2[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}