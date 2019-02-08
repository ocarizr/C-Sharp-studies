using System;
using System.Collections.Generic;

namespace CursoCSharp_P4
{
    class ListConsolidationExercise
    {
        private List<Employee> Employees;

        public ListConsolidationExercise()
        {
            Employees = new List<Employee>();
        }

        public List<Employee> GetEmployees()
        {
            return Employees;
        }

        public void AddEmployee(int id, string name, double salary)
        {
            if (Employees.Count > 0)
            {
                foreach (Employee employee in Employees)
                {
                    if (employee.ID == id)
                    {
                        Console.WriteLine("Already have a Employee with this ID");
                        return;
                    }
                }
            }
            Employee e = new Employee(id, name, salary);
            Employees.Add(e);
        }

        public void UpdateSalary(int id, int value)
        {
            Employees.Find(x => x.ID == id).SalaryUpdate(value);
        }
    }
}
