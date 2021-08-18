namespace SingleResponsibilityPrinciple
{
    class AccountGenerator
    {
        AccountData accountData = new AccountData();

        public void GenerateUsername(Person person)
        {
            if (person is null)
            {
                return;
            }

            accountData.Username = $"{person.FirstName!.Substring(0, 1).ToLower()}{person.LastName!.ToLower()}";
            Console.WriteLine($"{person} username is {accountData.Username}.");
        }

        public AccountData GetAccountData() => accountData;
    }
}
