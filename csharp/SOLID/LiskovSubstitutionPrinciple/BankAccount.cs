namespace LiskovSubstitutionPrinciple;

public abstract class BankAccount
{
    public decimal Balance { get; protected set; }
    public string AccountNumber { get; protected set; }

    public BankAccount(string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0M;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("O valor do depósito deve ser positivo.");
        Balance += amount;
    }

    public abstract void Withdraw(decimal amount);
}