namespace InterfaceSegregationPrinciple
{
    interface IPhysicalBook : IBook
    {
        int Pages { get; set; }
    }
}
