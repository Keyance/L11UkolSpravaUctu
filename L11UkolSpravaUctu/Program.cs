using L11UkolSpravaUctu;


try
{
	Account account = new Account();
    account.Deposit(1354);
    account.OwnerName = "Mojmír";
    account.Withdraw(2547);

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