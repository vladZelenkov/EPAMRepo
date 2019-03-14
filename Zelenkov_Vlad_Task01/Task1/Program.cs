using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Input the rectangle side.");
            while (a <= 0)
            {
                Console.Write("Input a: ");
                if (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Error. Input the positive number.");
                }
            }
            while (b <= 0)
            {
                Console.Write("Input b: ");
                if (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Error. Input the positive number.");
                }
            }
            Console.WriteLine($"Area = {a * b}");
            Console.ReadKey();
        }
    }
}
