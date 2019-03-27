using System;
using System.Text;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;
            System.Diagnostics.Stopwatch strWatch = new System.Diagnostics.Stopwatch();
            strWatch.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }              
            double strTime = strWatch.Elapsed.TotalMilliseconds;
            strWatch.Stop();
            System.Diagnostics.Stopwatch sbWatch = new System.Diagnostics.Stopwatch();
            sbWatch.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }       
            double sbTime = strWatch.Elapsed.TotalMilliseconds;
            sbWatch.Stop();
            Console.WriteLine("Work speed:");
            Console.WriteLine("{0,-15} {1,15}", "String", "StringBuilder");
            Console.WriteLine("{0,-15:F5} {1,15:F5}",
                strTime, sbTime);
            Console.ReadKey();
        }
    }
}
