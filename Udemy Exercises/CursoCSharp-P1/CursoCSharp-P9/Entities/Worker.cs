using System.Collections.Generic;
using CursoCSharp_P9.Entities.Enums;

namespace CursoCSharp_P9.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        // Composition Properties
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            if (Contracts.Contains(contract))
            {
                Contracts.Remove(contract);
            }
            else
            {
                System.Console.WriteLine("The worker doesn't have this contract.");
            }
            
        }

        public double Income(int year, int month)
        {
            double income = BaseSalary;

            foreach(HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    income += contract.TotalValue();
                }
            }

            return income;
        }
    }
}
