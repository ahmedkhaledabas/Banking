using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__2
{
    internal class SavingUtil 
    {



        public static void Display(List<SavingsAccount> accounts)
        {
            Console.WriteLine("\n=== Savings Accounts ==========================================");
            foreach (var acc in accounts)
            {
                Console.WriteLine(acc);
            }
        }

        public static void Deposit(List<SavingsAccount> accounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to Savings Accounts =================================");
            foreach (var acc in accounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }

        public static void Withdraw(List<SavingsAccount> accounts, double amount)
        {
           
            Console.WriteLine("\n=== Withdrawing from Savings Accounts ==============================");
            foreach (var acc in accounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }
    }
}
