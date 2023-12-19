using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__2
{

    internal class CheckingAccount : SavingsAccount
    {
        const double Fee = 1.50;

        public CheckingAccount(string name = "Unnamed Account", double balance = 0) : base(name, balance)
        {
        }

        //has a fee of $1.50 per withdrawal transaction.Every withdrawal transaction will be assessed this flat fee.


        public override bool Withdraw(double amount)
        {
            amount += Fee;
            return base.Withdraw(amount);
        }
    }
}
