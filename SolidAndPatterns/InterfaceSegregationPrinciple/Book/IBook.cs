namespace InterfaceSegregationPrinciple
{
    interface IBook : ILibraryItem
    {
        string? Author { get; set; }
    }
}
