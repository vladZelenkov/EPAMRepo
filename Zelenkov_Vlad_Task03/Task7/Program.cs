using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the text:");
            string text = Console.ReadLine();
            text = !string.IsNullOrEmpty(text) ? text : "В 7:55 я встал, позавтракал и к 10:77 пошел на работу.";
            Console.WriteLine($"Text:\n {text}");
            string pattern = @"\d{1,2}:\d{2}";
            int i = 0;
            foreach (var item in Regex.Matches(text, pattern))
            {
                string time = item.ToString();
                string hhStr = Regex.Match(time, @"\d{1,2}:").Value;
                int hh = int.Parse(hhStr.Remove(hhStr.Length - 1, 1));
                if (hh <= 24)
                {
                    int mm = int.Parse(Regex.Match(time, @":\d{2}").Value.Remove(0, 1));
                    if (mm <= 59)
                    {
                        i++;
                    }
                }
            }
            Console.WriteLine($"Time in the text contains {i} time");
            Console.ReadKey();
        }
    }
}
