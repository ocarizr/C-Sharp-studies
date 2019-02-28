using System;
using CursoCSharp_P12.Entities;

namespace CursoCSharp_P12
{
    class Program
    {
        static void Main(string[] args)
        { 
            Account a = new BusinessAccount(1074, "Monica", 1000, 300);
            Account b = new SavingsAccount(1388, "Giovanna", 1500, 1.5);

            if (a is BusinessAccount)
            {
                a.Deposit(100);
            } else if (a is SavingsAccount)
            {
                a.Withdraw(100);
            }

            Console.WriteLine(a.Balance);

            if (b is BusinessAccount)
            {
                b.Withdraw(100);
            } else if (b is SavingsAccount)
            {
                ((SavingsAccount)b).UpdateBalance();
            }

            Console.WriteLine(b.Balance);

            BusinessAccount c = new BusinessAccount();

            if (a is BusinessAccount)
            {
                c = (BusinessAccount)a;
            }
            else if (b is BusinessAccount)
            {
                c = b as BusinessAccount;
            }

            Console.WriteLine(c.LoanLimit);

            c.GetLoan(100);

            Console.WriteLine(c.Balance);
            Console.WriteLine(c.LoanLimit);
        }
    }
}
