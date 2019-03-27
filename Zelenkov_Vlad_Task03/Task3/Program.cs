using System;
using System.Globalization;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ruInfo = new CultureInfo("ru", false);
            CultureInfo enInfo = new CultureInfo("en", false);
            CultureInfo invariant = new CultureInfo("");

            CultureInfoPrint(ruInfo, enInfo);
            Console.WriteLine();
            CultureInfoPrint(enInfo, invariant);
            Console.WriteLine();
            CultureInfoPrint(ruInfo, invariant);

            Console.ReadKey();
        }

        public static void CultureInfoPrint(CultureInfo parCulture1, CultureInfo parCulture2)
        {
            PrintSeparator();
            string namecult1 = string.IsNullOrEmpty(parCulture1.Name) ? "invariant" : parCulture1.Name;
            string namecult2 = string.IsNullOrEmpty(parCulture2.Name) ? "invariant" : parCulture2.Name;
            Console.WriteLine("|{0,-17}|{1,15}{2,15}{3,15}{4,15}", "Name",
               namecult1, '|', namecult2, '|');
            PrintSeparator();
            Console.WriteLine("|{0,-17}|{1,20:D}{2,10}{3,20:D}{4,10}", "DateFormat",
               parCulture1.DateTimeFormat.LongDatePattern, '|',
               parCulture2.DateTimeFormat.LongDatePattern, '|');
            PrintSeparator();
            Console.WriteLine("|{0,-17}|{1,20:D}{2,10}{3,20:D}{4,10}", "TimeFormat",
               parCulture1.DateTimeFormat.LongTimePattern, '|',
               parCulture2.DateTimeFormat.LongTimePattern, '|');
            PrintSeparator();
            Console.WriteLine("|{0,-17}|{1,20:D}{2,10}{3,20:D}{4,10}", "NumSeparator",
               parCulture1.NumberFormat.NumberDecimalSeparator, '|',
               parCulture2.NumberFormat.NumberDecimalSeparator, '|');
            PrintSeparator();
            Console.WriteLine("|{0,-17}|{1,20:D}{2,10}{3,20:D}{4,10}", "GroupSeparator",
               parCulture1.NumberFormat.NumberGroupSeparator, '|',
               parCulture2.NumberFormat.NumberGroupSeparator, '|');
            PrintSeparator();
        }

        public static void PrintSeparator()
        {
            for (int i = 0; i < 79; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }

    }
}
