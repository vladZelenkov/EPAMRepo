using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Input the number: ");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                int k = 1;
                int m = n - 1;
                for (int i = 0; i < n; i++)
                {
                    for (int l = 0; l < m; l++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < k; j++)
                    {
                        Console.Write("*");
                    }
                    k += 2;
                    m--;
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
