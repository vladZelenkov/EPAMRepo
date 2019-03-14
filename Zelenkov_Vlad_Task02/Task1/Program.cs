using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 20;
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
            }
            MySort(array);
            Console.WriteLine($"Max = {array[0]}");
            Console.WriteLine($"Min = {array[array.Length - 1]}");
            Console.WriteLine("Sort array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }

        public static void MySort(int[] array)
        {
            int i = 1;
            while (i < array.Length)
            {
                while (i > 0 && array[i] < array[i - 1])
                {
                    int temp;
                    temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                    i--;
                }
                i++;
            }
        }
    }
}
