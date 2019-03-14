using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Input the number: ");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
