using CursoCSharp_P12.Entities;
using System;

namespace CursoCSharp_P12
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Account a = new BusinessAccount(1074, "Monica", 1000, 300);
            Account b = new SavingsAccount(1388, "Giovanna", 1500, 1.5);

            if (a is BusinessAccount)
            {
                a.Deposit(100);
            }

            Console.WriteLine(a.Balance);

            if (b is SavingsAccount)
            {
                ((SavingsAccount)b).UpdateBalance();
            }

            Console.WriteLine(b.Balance);

            BusinessAccount c = new BusinessAccount();

            if (a is BusinessAccount)
            {
                c = (BusinessAccount)a;
            }

            Console.WriteLine(c.LoanLimit);

            c.GetLoan(100);

            Console.WriteLine(c.Balance);
            Console.WriteLine(c.LoanLimit);

            a.Withdraw(50);
            b.Withdraw(50);
            c.Withdraw(50);

            Console.WriteLine("$" + a.Balance);
            Console.WriteLine("$" + b.Balance);
            Console.WriteLine("$" + c.Balance);
        }
    }
}
