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

            Department department = new Department();
            string name;
            WorkerLevel level;
            double baseSalary;

            int ammountOfContracts;
            HourContract contract = new HourContract();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter department's name: ");
            department.Name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter worker data:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            worker = new Worker(name, level, baseSalary, department);

            Console.Write("How many contracts to this worker: ");
            ammountOfContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < ammountOfContracts; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Enter #{i + 1} contract data:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Date (DD/MM/YYYY): ");
                contract.Date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                contract.ValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Durantiom (Hours): ");
                contract.Hours = int.Parse(Console.ReadLine());

                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] date = Console.ReadLine().ToString().Split("/");
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department);
            Console.WriteLine("Income for "
                + date[0] + "/" + date[1] + ": "
                + worker.Income(int.Parse(date[1]), int.Parse(date[0]))
                );
        }
    }
}
