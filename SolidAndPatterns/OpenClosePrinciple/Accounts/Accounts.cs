namespace OpenClosePrinciple
{
    class Accounts : IAccounts
    {
        public virtual EmployeeModel Create(IPerson person)
        {
            var output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName!.Substring(0, 1).ToLower()}{person.LastName!.ToLower()}@test.com";
            return output;
        }
    }
}
