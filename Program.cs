// See https://aka.ms/new-console-template for more information
using MySuperBank;

var account = new BankAccount("Dobri", 10000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

account.MakeWithdrawal(120, DateTime.Now, "New video game");
Console.WriteLine($"After you bought your new video game your account balance remain {account.Balance}");

account.MakeWithdrawal(50, DateTime.Now, "X box Game");
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetAccountHistory());

//Test for negative balance:
try
{
    account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(e.ToString());
}


// Test that the initial balances must be positive.
BankAccount invalidAccount;
try
{
    invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString());   
}


