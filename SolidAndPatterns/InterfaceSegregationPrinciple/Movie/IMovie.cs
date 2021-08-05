using System.Collections.Generic;

namespace InterfaceSegregationPrinciple
{
    interface IMovie : IPlayable
    {
        string? Director {  get; set; }
        List<string> Actors {  get; set; }
    }
}
