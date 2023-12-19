using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task__2
{
    internal class Account
    {
        //Overload + operator in Account class (to sum the balances of two objects you will be create in Main)




        private string name;
        private double balance;

        public string Name { get => name; set => name = value; }
        public double Balance { get => balance; set => balance = value; }

        public Account(string name = "Unnamed Account", double balance = 0.0)
        {
            this.Name = name;
            this.Balance = balance;
        }

        public virtual bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                Balance += amount;
                return true;
            }
        }

        public virtual bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetBalance()
        {
            return Balance;
        }

        public override string ToString()
        {
            return $"[Account: {Name}: {Balance}]";
        }


        public static double operator +(Account lhs, Account rhs)
        {

            double temp = lhs.Balance + rhs.Balance;
            return temp;
        }
    }
}
