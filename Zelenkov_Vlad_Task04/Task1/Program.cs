using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> suspiciousPersons = new List<User>();
            suspiciousPersons.Add(new User("Vitaly", "Milonov", "Valentinovich", new DateTime(1974, 1, 23)));
            suspiciousPersons.Add(new User("Irina", "Yarovaya", "Anatolevna", new DateTime(1976, 7, 17)));
            suspiciousPersons.Add(new User("Navalniy", "Alexey", "Anatolevich", new DateTime(1976, 6, 4)));
            suspiciousPersons.Add(new User("Ramzan", "Kadirov", "Akhmatovich", new DateTime(1976, 7, 5)));

            Console.WriteLine("Data about suspicious persons:\n");
            foreach (var item in suspiciousPersons)
            {
                Console.WriteLine(item.ShortInfo());
            }
            Console.WriteLine();
            Console.WriteLine("Full information about suspicious persons:\n");
            foreach (var item in suspiciousPersons)
            {
                Console.WriteLine(item.LongInfo());
            }
            Console.ReadKey();
        }
    }
}
