using System;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number: ");
            string number = Console.ReadLine();
            string pattern = @"-?\d+(\.\d+(e-?\d+)?)?";
            if (Regex.IsMatch(number, pattern))
            {
                string regNumber = Regex.Match(number, pattern).Value;
                if (Regex.IsMatch(regNumber, @"e-?\d+"))
                {
                    Console.WriteLine($"The number {regNumber} in scientific notation");
                }
                else
                {
                    Console.WriteLine($"The number {regNumber} in common notation");
                }
            }
            else
            {
                Console.WriteLine($"{number} is not number");
            }
            Console.ReadKey();
        }
    }
}
