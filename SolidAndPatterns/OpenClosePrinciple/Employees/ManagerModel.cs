namespace OpenClosePrinciple
{
    class ManagerModel : IApplicant
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new ManagerAccounts();
    }
}
