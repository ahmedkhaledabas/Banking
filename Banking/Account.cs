using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    internal class Account
    {
        private decimal Balance { get; set; }
        private string Name { get; set; }

        public Account(string name, decimal startingBalance)
        {
            if (startingBalance > 0 && startingBalance <= 100000 && startingBalance >= 500)
            {
                Balance = startingBalance;
                Console.WriteLine("Success");
            }
            else
                Console.WriteLine($"Sorry , Your Amount {startingBalance} Invalid");

            Name = name;
        }
        public bool Deposit(decimal amountToAdd)
        {
            if (amountToAdd > 0 && amountToAdd <=100000)
            {
                Balance += amountToAdd;
                return true;

            }
            else
            {
                return false;
            }
        }

        public static void DoDeposit(Account account)
        {
            Console.WriteLine("Enter Your Amount You Need To Deposit");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            if (account.Deposit(amount))
            {
                Console.WriteLine($"Success Deposit {amount}");
            }
            else Console.WriteLine($"Invalid Amount {amount}");
        }

        public bool Withdraw(decimal amount)
        {
            if (amount < Balance - 100 && amount > 0)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void DoWithdraw(Account account)
        {
            Console.WriteLine("Enter Your Amount You Need To Withdraw");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            if (account.Withdraw(amount))
            {
                Console.WriteLine($"Success Withdraw {amount}");
            }
            else Console.WriteLine($"Invalid Amount {amount}");
        }

        public void Print()
        {
            Console.WriteLine($"Welcome {Name} Your Balance = {Balance} ");
        }

        public static void DoPrint(Account account)
        {
            account.Print();
        }

       
    }
}
