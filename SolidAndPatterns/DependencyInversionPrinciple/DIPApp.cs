using System;

namespace DependencyInversionPrinciple
{
    public class DIPApp
    {
        public void Run()
        {
            var owner = Factory.CreatePerson();
            owner.FirstName = "Rafael";
            owner.LastName = "Ocariz";
            owner.Email = "rafael@test.com";
            owner.BirthDate = DateTime.Parse("03/07/1990");

            var chore = Factory.CreateChore();
            chore.ChoreName = "La La La";
            chore.Owner = owner;
            
            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();
        }
    }
}
