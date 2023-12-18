namespace Task__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accounts
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            //Account acc = new Account("Ahmed",1000);
            //Account acc1 = new Account("Ka",200);
            //double r = acc + acc1;
            //Console.WriteLine(r);

            //AccountUtil.Display(accounts);
            //AccountUtil.Deposit(accounts, 1000);
            //AccountUtil.Withdraw(accounts, 2000);


            ////// Savings
            //var savAccounts = new List<SavingsAccount>();
            //savAccounts.Add(new SavingsAccount());
            //savAccounts.Add(new SavingsAccount("Superman"));
            //savAccounts.Add(new SavingsAccount("Batman", 2000));
            //savAccounts.Add(new SavingsAccount("Wonderwoman", 5000, 5.0));

            //SavingUtil.Display(savAccounts);
            //SavingUtil.Deposit(savAccounts, 1000);
            //SavingUtil.Withdraw(savAccounts, 2000);

            ////// Checking
            //var checAccounts = new List<CheckingAccount>();
            //checAccounts.Add(new CheckingAccount());
            //checAccounts.Add(new CheckingAccount("Larry2"));
            //checAccounts.Add(new CheckingAccount("Moe2", 2000));
            //checAccounts.Add(new CheckingAccount("Curly2", 5000));

            //CheckingUtil.Display(checAccounts);
            //CheckingUtil.Deposit(checAccounts, 1000);
            //CheckingUtil.Withdraw(checAccounts, 2000);
            //CheckingUtil.Withdraw(checAccounts, 2000);    

            //// Trust
            //var trustAccounts = new List<TrustedAccount>();
            //trustAccounts.Add(new TrustedAccount());
            //trustAccounts.Add(new TrustedAccount("Superman2"));
            //trustAccounts.Add(new TrustedAccount("Batman2", 2000));
            //trustAccounts.Add(new TrustedAccount("Wonderwoman2", 5000, 5.0));

            //TrustedUtil.Display(trustAccounts);
            //TrustedUtil.Deposit(trustAccounts, 1000);
            //TrustedUtil.Deposit(trustAccounts, 6000);
            //TrustedUtil.Withdraw(trustAccounts, 2000);
            //TrustedUtil.Withdraw(trustAccounts, 3000);
            //TrustedUtil.Withdraw(trustAccounts, 500);

            //Console.WriteLine();
        }
    }
}
