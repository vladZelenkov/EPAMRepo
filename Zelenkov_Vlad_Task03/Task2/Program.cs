using System;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first string:");
            string first = Console.ReadLine();
            Console.WriteLine("Input second string:");
            string second = Console.ReadLine();
            char[] charArraySecond = second.ToCharArray();
            var rezString = new StringBuilder();
            for (int i = 0; i < first.Length; i++)
            {
                rezString.Append(first[i]);
                if (Task1.Program.Contains(first[i], charArraySecond))
                {
                    rezString.Append(first[i]);
                }
            }
            Console.WriteLine($"Result string \n{rezString.ToString()}");
            Console.ReadKey();
        }
    }
}
