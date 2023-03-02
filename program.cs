BankAccount newaccount = new SavingsAccount("Jim", 250);


Console.WriteLine(newaccount.customerName + "'s starting balance is $" + newaccount.getBalance());

// he added 100 more
newaccount.deposit(-100);

Console.WriteLine(newaccount.customerName + "'s now balance is $" + newaccount.getBalance());
