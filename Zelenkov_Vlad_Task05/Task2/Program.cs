using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ring ring1 = new Ring(1, 4, 6, 3);
            Ring ring2 = new Ring(3, 7, 6, 8);
            Ring ring3 = new Ring(2, 6, 6, 3);
            Ring[] rings = new[] { ring1, ring2, ring3 };

            Console.WriteLine("Rings:");
            foreach (var item in rings)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }

            ring3.InnerRadius = 14;

            Console.WriteLine();
            Console.WriteLine("New Rings:");
            foreach (var item in rings)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
