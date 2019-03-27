using System;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the text:");
            string text = Console.ReadLine();
            string textDefault = "<b>Это</b> текст <i>с</i> <font color=”red”>HTML</font> кодами";
            text = !string.IsNullOrEmpty(text) ? text : textDefault;
            string pattern = @"<.*?>";
            string newText = Regex.Replace(text, pattern, "_");
            Console.WriteLine($"Old text: {text}");
            Console.WriteLine($"New text: {newText}");
            Console.ReadKey();
        }
    }
}
