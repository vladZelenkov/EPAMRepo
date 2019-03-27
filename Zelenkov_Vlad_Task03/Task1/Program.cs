using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string:");
            string input = Console.ReadLine();
            var words = new List<string>();
            char[] punctuation = new[] { ',', '.', ':', ';', '!', '?', '-', '(', ')' };
            input = input.Trim();
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    temp.Append(input[i]);
                }
                else if (!string.IsNullOrEmpty(temp.ToString()))
                {
                    words.Add(temp.ToString());
                    temp.Clear();
                }
                if (!string.IsNullOrEmpty(temp.ToString()) && i == input.Length - 1)
                {
                    words.Add(temp.ToString());
                    temp.Clear();
                }
            }
            int charCount = 0;
            foreach (var item in words)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (!Contains(item[i], punctuation))
                    {
                        charCount++;
                    }
                }
            }
            double averageLenght = charCount / words.Count;
            Console.WriteLine($"Average lenght of word = {averageLenght}");
            Console.ReadKey();
        }

        public static bool Contains(char parChar, char[] parCharArray)
        {
            for (int i = 0; i < parCharArray.Length; i++)
            {
                if (parCharArray[i].Equals(parChar))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
