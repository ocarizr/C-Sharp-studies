namespace InterfaceSegregationPrinciple
{
    interface IPlayable : ILibraryItem
    {
        int PlayTimeInMinutes { get; set; }
    }
}
