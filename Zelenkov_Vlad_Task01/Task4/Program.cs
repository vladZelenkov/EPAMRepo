using System;

namespace Task4
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
                    int k = 1;
                    for (int j = 0; j < i + 1; j++)
                    {
                        int l = n - j;
                        for (int o = 0; o < l; o++)
                        {
                            Console.Write(" ");
                        }
                        for (int m = 0; m < k; m++)
                        {
                            Console.Write("*");
                        }
                        l--;
                        k += 2;
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
