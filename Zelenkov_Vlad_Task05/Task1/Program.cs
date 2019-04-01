using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> workers = new List<Employee>();
            Employee director = new Employee("Nikolay", "Sobolev", "director");
            Employee depHead = new Employee("Danya", "Kraster", "departament head");
            Employee worker1 = new Employee("Konstantin", "Paraev", "");
            Employee worker2 = new Employee("Konstantin", "Paraev", "worker");

            workers.Add(director);
            workers.Add(depHead);
            workers.Add(worker1);
            workers.Add(worker2);
            director.Experience = 6;
            depHead.Experience = 2;

            PrintWorkers(workers);

            PrintChangePosition(worker2, "departament head");
            Console.WriteLine();
            PrintWorkers(workers);
            Console.ReadKey();
        }

        public static void PrintWorkers(List<Employee> parList)
        {
            foreach (var item in parList)
            {
                Console.WriteLine($"Employee {item.Name}, experience {item.Experience}, position {item.Position}");
            }
        }

        public static void PrintChangePosition(Employee person, string parNewPosition)
        {
            if (person.DefinePosition(parNewPosition))
            {
                Console.WriteLine("position succesful changed");
            }
            else
            {
                Console.WriteLine("don't allow");
            }
        }
    }
}
