namespace OpenClosePrinciple
{
    class EmployeeModel : IPerson
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public bool IsManager { get; set; } = false;
    }
}
