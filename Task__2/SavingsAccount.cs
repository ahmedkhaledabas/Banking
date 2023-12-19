using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__2
{
    internal class SavingsAccount : Account
    {
        private double InterestRata {  get; set; }
        public SavingsAccount(string name = "Unnamed Account", double balance =0 , double rate = 0):base(name,balance) 
        {
            rate = InterestRata;
        }


        public override bool Deposit(double amount)
        {
            amount = amount + (amount * InterestRata / 100);
            return base.Deposit(amount);
        }

        public override string ToString()
        {
            return $"[Saving Account: {Name}: {Balance}]";
        }
    }
}
