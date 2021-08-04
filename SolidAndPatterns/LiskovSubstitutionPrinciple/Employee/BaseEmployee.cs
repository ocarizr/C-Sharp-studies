namespace LiskovSubstitutionPrinciple
{
    abstract class BaseEmployee : IEmployee
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal Salary { get; protected set; }
        public abstract void CalculatePerHourRate(int rank);
    }
}
