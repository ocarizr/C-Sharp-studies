using System;

namespace LiskovSubstitutionPrinciple
{
    class Manager : BaseManagedEmployee, IManager
    {
        const decimal baseRate = 12.5M;
        const decimal incrementBase = 1M;

        public override void CalculatePerHourRate(int rank)
        {
            Salary = baseRate + incrementBase * rank;
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine($"I, {FirstName} {LastName}, am generating performance reviews.");
        }
    }
}
