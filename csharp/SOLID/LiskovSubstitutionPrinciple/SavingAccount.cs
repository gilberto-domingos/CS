namespace LiskovSubstitutionPrinciple;

public class SavingAccount : BankAccount
{
    public SavingAccount(string accountNumber) : base(accountNumber) {}

    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("O valor do saque deve ser positivo.");

        if (Balance < amount)
            throw new InvalidOperationException("Saldo insuficiente.");

        Balance -= amount;
    }
}