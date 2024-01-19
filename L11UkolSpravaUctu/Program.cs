using L11UkolSpravaUctu;
	Account account = new Account();

try
{
    account.Deposit(1354);
    account.OwnerName = "Mojmír";
    account.Withdraw(2547);
    account.Deposit(-157);
    account.Balance = -4688;

}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}

try
{
    account.Balance = -4688;

}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}