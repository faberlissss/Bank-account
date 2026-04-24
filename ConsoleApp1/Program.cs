using ConsoleApp1;

Account fesenkoAccount = new Account("Fesenko account", 200.00m);
Account fesenkoUSAccount = new Account("Fesenko US account", 2000000.00m);

fesenkoAccount.Withdrawal(30);
Console.WriteLine("The balance of Fesenko account is now: " + fesenkoAccount.Balance);
fesenkoUSAccount.Deposit(300);
Console.WriteLine("The balance of Fesenko other account is now: " + fesenkoUSAccount.Balance);
