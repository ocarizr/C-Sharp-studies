namespace OpenClosePrinciple
{
    interface IApplicant : IPerson
    {
        IAccounts AccountProcessor { get; set; }
    }
}
