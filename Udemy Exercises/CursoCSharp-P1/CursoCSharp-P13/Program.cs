using System;
using System.Collections.Generic;
using  CursoCSharp_P13.Entities;

namespace CursoCSharp_P13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int amountOfEmployees = int.Parse(Console.ReadLine());
            for (int i = 0; i < amountOfEmployees; i++)
            {
                Console.WriteLine("Employee #" + (i+1) + " Data:");
                Console.Write("Outsourced? (y/n)");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: $");
                double valuePerHour = double.Parse(Console.ReadLine());
                Employee employee;
                if (outsourced == 'y')
                {
                    Console.Write("Additional charge: $");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employee = new OutsourceEmployee(name, hours, valuePerHour, additionalCharge);
                }
                else
                {
                    employee = new Employee(name, hours, valuePerHour);
                }
                employees.Add(employee);
            }

            Console.WriteLine();

            Console.WriteLine("Payments:");
            for (var i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
