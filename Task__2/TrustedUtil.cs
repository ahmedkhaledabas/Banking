using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__2
{
    internal class TrustedUtil :SavingUtil
    {
        public static void Display(List<TrustedAccount> accounts)
        {
            Console.WriteLine("\n=== Trusted Accounts ==========================================");
            foreach (var acc in accounts)
            {
                Console.WriteLine(acc);
            }
        }

        public static void Deposit(List<TrustedAccount> accounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to Trusted Accounts =================================");
            foreach (var acc in accounts)
            {
                if (acc.Deposit(amount))
                {
                    Console.WriteLine($"Deposited {amount} to {acc}");
                    if(amount >= 5000) Console.WriteLine($"Congratulation You Get Bouns");
                }

                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }

        public static void Withdraw(List<TrustedAccount> accounts, double amount)
        {

            Console.WriteLine("\n=== Withdrawing from Trusted Accounts ==============================");
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
