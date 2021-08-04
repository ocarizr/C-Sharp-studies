namespace OpenClosePrinciple
{
    class ManagerAccounts : Accounts
    {
        public override EmployeeModel Create(IPerson person)
        {
            var output = base.Create(person);
            output.IsManager = true;
            return output;
        }
    }
}
