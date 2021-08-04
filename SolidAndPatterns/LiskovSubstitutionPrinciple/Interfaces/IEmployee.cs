namespace LiskovSubstitutionPrinciple
{
    interface IEmployee
    {
        string? FirstName { get; set; }
        string? LastName { get; set; }
        decimal Salary { get; }

        void CalculatePerHourRate(int rank);
    }
}