namespace LiskovSubstitutionPrinciple
{
    class Employee : BaseManagedEmployee
    {
        const decimal baseRate = 10.2M;
        const decimal incrementBase = 0.2M;

        public override void CalculatePerHourRate(int rank)
        {
            Salary = baseRate + incrementBase * rank;
        }
    }
}
