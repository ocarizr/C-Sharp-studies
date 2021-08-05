using System;

namespace InterfaceSegregationPrinciple
{
    interface ILibraryItem
    {
        Guid Id { get; set; }
        string? Title { get; set; }
    }
}
