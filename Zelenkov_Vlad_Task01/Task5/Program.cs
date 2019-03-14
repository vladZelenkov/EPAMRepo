using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            int sum = 0;
            for (int i = 3; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;              
                }
            }
            Console.Write($"Summ = {sum}");
            Console.ReadKey();
        }
    }
}
