using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var roundList = new List<Round>();
            var circle1 = new Round();
            circle1.X = 5;
            circle1.Y = 4;
            circle1.Radius = 7;
            var circle2 = new Round(1, 2, 3);
            var circle3 = new Round(-1, 4, -5);
            roundList.Add(circle1);
            roundList.Add(circle2);
            roundList.Add(circle3);
            foreach (var item in roundList)
            {
                Console.WriteLine($"| X - {item.X,4} | Y - {item.Y,4} | Radius - {item.Radius,4} | Length - {item.Lenght,9:00.00} | Area - {item.Area,9:00.00} |");
            }
            Console.ReadKey();
        }
    }
}
