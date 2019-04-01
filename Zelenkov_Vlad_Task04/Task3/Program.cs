using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Triangle(3, 4, 5);
            var t2 = new Triangle(5, 6, 2);
            var t3 = new Triangle(4, 4, 4);
            var tList = new List<Triangle>();
            tList.Add(t1);
            tList.Add(t2);
            tList.Add(t3);        
            Console.WriteLine("------------------------");
            foreach (var item in tList)
            {
                Console.WriteLine("Triangle:");
                Console.WriteLine($"| {item.A} | {item.B} | {item.C} |");
                Console.WriteLine($"Perimeter = {item.GetPerimeter()}");
                Console.WriteLine($"Area = {item.GetArea():00.000}");
                Console.WriteLine("------------------------");
            }

            Console.ReadKey();
        }
    }
}
