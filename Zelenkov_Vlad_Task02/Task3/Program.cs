using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100) - 50;
            }
            int summ = 0;
            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    summ += array[i];
                }
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Summ = {summ}");
            Console.ReadKey();
        }
    }
}
