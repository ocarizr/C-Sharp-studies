namespace InterfaceSegregationPrinciple
{
    class ReferenceBook : IPhysicalBook
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public int Pages { get; set; }
        public string? Author { get; set; }
    }
}
