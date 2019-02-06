using System.Globalization;

namespace CursoCSharp_P2
{
    class AccountData
    {
        public string Name { get; private set; }
        public int AccountNumber { get; private set; }
        public double Budget { get; private set; }

        public AccountData(string name, int accountNumber)
        {
            Name = name;
            AccountNumber = accountNumber;
        }

        public AccountData(string name, int accountNumber, double budget) : this(name, accountNumber)
        {
            Budget = budget;
        }

        public void Deposit(double value)
        {
            Budget += value;
        }

        public void Withdraw(double value)
        {
            Budget -= (value + 5.0);
        }

        public override string ToString()
        {
            return $"Account {AccountNumber}, Titular: {Name}, Budget: $ {Budget.ToString("F2", CultureInfo.InvariantCulture)}.";
        }
    }
}
