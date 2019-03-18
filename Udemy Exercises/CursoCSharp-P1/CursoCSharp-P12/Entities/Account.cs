namespace CursoCSharp_P12.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public virtual void Withdraw(double value)
        {
            Balance -= value + 5;
        }
    }
}
