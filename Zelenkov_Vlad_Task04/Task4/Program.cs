using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString s1 = new MyString("1string1");
            MyString s2 = new MyString("string");
            MyString s3 = new MyString("1string1");
            Console.WriteLine("Work with MyString:");
            Console.WriteLine($"Summ = {(s1 + s2).ToString()}");
            Console.WriteLine($"Difference = {(s1 - s2).ToString()}");
            Console.WriteLine($"Compare s1 and s2 is not equal {s1 != s2}");
            Console.WriteLine($"Compare s1 and s3 is equal {s1 == s3}");
            Console.WriteLine($"Strings - {s1.ToString()}, {s2.ToString()}, {s3.ToString()}");
            Console.ReadKey();
        }
    }
}
