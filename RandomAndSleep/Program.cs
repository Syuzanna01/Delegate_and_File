using System;

namespace RandomAndSleep
{
    class Program
    {
        static void Main()
        {
            Random random = new();

            Console.Write("n = ");

            int n = int.Parse(Console.ReadLine());
            
            Console.Write("m = ");

            int m = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + ",  ");

                    Thread.Sleep(800);
                }
                Console.WriteLine();
            }
        }
    }
}