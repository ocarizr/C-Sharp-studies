using System;
using System.Globalization;
using CursoCSharp_P9.Entities;
using CursoCSharp_P9.Entities.Enums;

namespace CursoCSharp_P9
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker;

            string departmentName, name, level;
            double baseSalary;

            int ammountOfContracts;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter department's name: ");
            departmentName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter worker data:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            level = Console.ReadLine();
            Console.Write("Base Salary: $");
            baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            worker = new Worker(name, Enum.Parse<WorkerLevel>(level), baseSalary, new Department(departmentName));

            Console.Write("How many contracts to this worker: ");
            ammountOfContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < ammountOfContracts; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Enter #{i + 1} contract data:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: $");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Durantiom (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                worker.AddContract(new HourContract(date, valuePerHour, hours));
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] monthAndYear = Console.ReadLine().ToString().Split("/");
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for "
                + monthAndYear[0] + "/" + monthAndYear[1] + ": $"
                + worker.Income(int.Parse(monthAndYear[1]), int.Parse(monthAndYear[0]))
                );
        }
    }
}
