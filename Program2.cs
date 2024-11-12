using System;

public interface IAccount
{
    void Open_Account();
    void Close_Account();
}

public interface ICustomer
{
    void Display_Customer_Detail();
}

public class SavingAccount : IAccount, ICustomer
{ 
    private string customerName;
    private int accountNumber;
    private decimal balance;
 
    private static string bankName;

    public SavingAccount()
    {
        customerName = "Unknown";
        accountNumber = 0;
        balance = 0.0m;
    }

    public SavingAccount(string customerName, int accountNumber, decimal initialBalance)
    {
        this.customerName = customerName;
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    static SavingAccount()
    {
        bankName = "Default Bank";
    }
  
    public void Open_Account()
    {
        Console.WriteLine($"Account {accountNumber} opened for {customerName} at {bankName}.");
    }

    public void Close_Account()
    {
        Console.WriteLine($"Account {accountNumber} closed for {customerName}.");
        balance = 0;  
    }

    public void Display_Customer_Detail()
    {
        Console.WriteLine($"Customer Name: {customerName}");
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Balance: {balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. New Balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient balance to withdraw.");
        }
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New Balance: {balance:C}");
    }

    public void Check_And_Display_Balance()
    {
        Console.WriteLine($"Account Balance: {balance:C}");
    }
 
    public static void Main(string[] args)
    {
        SavingAccount account = new SavingAccount("Anuj", 12345, 500.00m);

        account.Open_Account();
        account.Display_Customer_Detail();

        account.Deposit(200.00m);
        account.Withdraw(100.00m);
        account.Check_And_Display_Balance();

        account.Close_Account();
    }
}
