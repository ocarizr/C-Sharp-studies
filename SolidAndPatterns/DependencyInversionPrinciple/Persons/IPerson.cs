using System;

namespace DependencyInversionPrinciple
{
    interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        DateTime BirthDate { get; set; }
    }
}