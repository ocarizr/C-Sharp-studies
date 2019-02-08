using System;
using System.Globalization;
using System.Collections.Generic;

namespace CursoCSharp_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ListLesson ll = new ListLesson();

            ListConsolidationExercise l = new ListConsolidationExercise();

            Console.Write("How many employees you want to register? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1}:");
                Console.Write("Employee ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Employee name: ");
                string name = Console.ReadLine();

                Console.Write("Employee Salary: $");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                l.AddEmployee(id, name, salary);
                Console.WriteLine();
            }

            bool stop = false;

            while (!stop)
            {
                Console.Write("Want to increase someones salary? (y/n) ");
                char option = char.Parse(Console.ReadLine());

                if (option == 'y' || option == 'Y')
                {
                    Console.Write("Ok, insert the ID of the employee: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("The percentage to increase: ");
                    int percentage = int.Parse(Console.ReadLine());

                    l.UpdateSalary(id, percentage);
                }
                else if (option == 'n' || option == 'N')
                {
                    stop = true;
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                }
                Console.WriteLine();
            }

            List<Employee> list = l.GetEmployees();

            foreach(Employee e in list)
            {
                Console.WriteLine(e);
            }
        }
    }
}
