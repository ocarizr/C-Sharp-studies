using System;

namespace CursoCSharp_P12.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void GetLoan(double value)
        {
            if (value <= LoanLimit)
            {
                Balance += value;
                LoanLimit -= value;
                return;
            }

            Console.WriteLine("You don have enought limit to take this loan.");
        }
    }
}
