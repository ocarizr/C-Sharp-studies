using System;

namespace LiskovSubstitutionPrinciple
{
    class CEO : BaseEmployee, IManager
    {
        const decimal baseRate = 20.0M;
        const decimal incrementBase = 2.5M;

        public override void CalculatePerHourRate(int rank)
        {
            Salary = baseRate + incrementBase * rank;
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine($"I, {FirstName} {LastName}, am generating performance reviews.");
        }

        public void FireSomeone(IEmployee employee)
        {
            Console.WriteLine($"Employee {employee.FirstName} {employee.LastName} do not work here anymore.");
        }
    }
}
