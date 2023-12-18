using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    enum MenuOptions
    {
        Withdraw,
        Deposit,
        Print,
        Quit,
        CreateAccount
    }
    internal class OptionMenue
    {
        public static void ReadUserOption()
        {

            Console.WriteLine("Welcome In Our Banking Program");
            Console.WriteLine("Now We Create A New Account For You");
            Console.WriteLine("Enter Your Name ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Your Starting Balance To Your Account ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());
            Account acc = new Account(userName, balance);
            do
            {

                Console.WriteLine("For Withdraw From Your Account Press 0");
                Console.WriteLine("For Deposit To You Account Press 1");
                Console.WriteLine("For Print Your Balance Press 2");
                Console.WriteLine("For Quit Program Press 3");
                int userChoise = Convert.ToInt16(Console.ReadLine());

                switch (userChoise)
                {
                    case (int)MenuOptions.Withdraw:
                        {
                            Account.DoWithdraw(acc);
                        }
                        break;

                    case (int)MenuOptions.Deposit:
                        {
                            Account.DoDeposit(acc);
                        }
                        break;

                    case (int)MenuOptions.Print:
                        {
                            Account.DoPrint(acc);
                        }
                        break;

                    case (int)MenuOptions.Quit:
                        {
                            Console.WriteLine(" GoodBye ");
                            Environment.Exit(0);
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Please Enter From Choise");
                        }
                        break;
                }

            } while (acc != null);
        }
    }
}
