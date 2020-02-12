using System;

class Program
{
    static void Main(string[] args)
    {
        IBankAccount a = new AccountA();
        IBankAccount b = new AccountB();
        a.DepositMoney(1500);
        b.DepositMoney(1000);
        a.TransferMoney(b, 900);
        Console.WriteLine(a.AccountBalance);
        Console.WriteLine(b.AccountBalance);
    }
}

interface IBankAccount
{
    decimal AccountBalance { get; }
    void DepositMoney(decimal amount);
    bool WithdrawMoney(decimal amount);
    bool TransferMoney(IBankAccount target, decimal amount);
}

class AccountA : IBankAccount
{
    private decimal balance;

    public decimal AccountBalance => balance;

    public void DepositMoney(decimal amount)
    {
        balance += amount;
    }

    public bool WithdrawMoney(decimal amount)
    {
        if (balance > amount)
        {
            balance -= amount;
            return true;
        }

        Console.WriteLine("Not enough funds in the account");
        return false;
    }

    public bool TransferMoney(IBankAccount target, decimal amount)
    {
        bool withdraw = WithdrawMoney(amount);
        if (withdraw)
        {
            target.DepositMoney(amount);
        }
        return withdraw;
    }
}

class AccountB : IBankAccount
{
    private decimal balance;

    public decimal AccountBalance => balance;

    public void DepositMoney(decimal amount)
    {
        balance += amount;
    }

    public bool WithdrawMoney(decimal amount)
    {
        if (balance > amount)
        {
            balance -= amount;
            return true;
        }

        Console.WriteLine("Not enough funds in the account");
        return false;
    }

    public bool TransferMoney(IBankAccount target, decimal amount)
    {
        bool withdraw = WithdrawMoney(amount);
        if (withdraw)
        {
            target.DepositMoney(amount);
        }
        return withdraw;
    }
}