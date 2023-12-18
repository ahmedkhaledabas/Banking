using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__2
{
    internal class TrustedAccount : Account
    {
        private const double Bouns = 50;

        public TrustedAccount( string name = "Unnamed Account", double balance = 0, double rate = 0) : base(name, balance)
        {

        }

        public bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
        //The Trust account deposit works just like a savings account deposit.
            else if(amount > 0 && amount < 5000) 
            {
                Balance += amount;
                return true;
            }
        //However, any deposits of $5000.00 or more will receive a $50.00 bonus deposited to the account.
            else
            {
                Balance += (amount+Bouns);
                return true;

            }
        }


        //The Trust account withdrawal should only allow 3 withdrawals per year and each of these must be less than 20% of the account balance
        public bool Withdraw(double amount)
        {

            // balance = 12000 , amount 2000, b = 2400
            double b = Balance * 0.2;
            if (Balance - amount >= 0 && amount < b)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
