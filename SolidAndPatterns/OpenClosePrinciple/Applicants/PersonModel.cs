namespace OpenClosePrinciple
{
    class PersonModel : IApplicant
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new Accounts();
    }
}
