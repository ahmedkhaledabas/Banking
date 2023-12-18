using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__2
{
    internal class CheckingUtil 
    {
        public static void Display(List<CheckingAccount> accounts)
        {
            Console.WriteLine("\n=== Checking Accounts ==========================================");
            foreach (var acc in accounts)
            {
                Console.WriteLine(acc);
            }
        }

        public static void Deposit(List<CheckingAccount> accounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to Checking Accounts =================================");
            foreach (var acc in accounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }


        public static void Withdraw(List<CheckingAccount> accounts, double amount)
        {

            Console.WriteLine("\n=== Withdrawing from Checking Accounts With 1.50$ Fee ==============================");
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
