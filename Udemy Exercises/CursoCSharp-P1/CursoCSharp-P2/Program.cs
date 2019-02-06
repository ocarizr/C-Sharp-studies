using System;
using System.Globalization;

namespace CursoCSharp_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountData ad;
            Console.Write("Enter with the account number: ");
            int accNum = int.Parse(Console.ReadLine());
            Console.Write("Enter with the Titular name: ");
            string name = Console.ReadLine();
            bool rightChoice = false;
            double budget = 0.0;

            while (rightChoice == false)
            {
                Console.Write("There's going to have an initial deposit? (y/n): ");
                char deposit = char.Parse(Console.ReadLine());

                if (deposit == 'y' || deposit == 'Y')
                {
                    Console.Write("Enter with the ammount to deposit: ");
                    budget = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    rightChoice = true;
                }
                else if (deposit == 'n' || deposit == 'N')
                {
                    rightChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }

            if (budget == 0.0)
            {
                ad = new AccountData(name, accNum);
            }
            else
            {
                ad = new AccountData(name, accNum, budget);
            }

            Console.WriteLine();

            Console.WriteLine("Account Data:");
            Console.WriteLine(ad);

            Console.WriteLine();

            Console.Write("Enter a deposit value: ");
            double depositValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ad.Deposit(depositValue);
            Console.WriteLine(ad);

            Console.WriteLine();

            Console.Write("Enter a withdraw value: ");
            double withdrawValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ad.Withdraw(withdrawValue);
            Console.WriteLine(ad);
        }
    }
}
