namespace LiskovSubstitutionPrinciple;

public class CheckingAccount : BankAccount
{
    private const decimal OverdraftLimit = 500M;

    public CheckingAccount(string accountNumber) : base(accountNumber) {}

    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("O valor do saque deve ser positivo.");
        
        if (Balance + OverdraftLimit < amount)
            throw new InvalidOperationException("Limite de crédito excedido.");

        Balance -= amount;
    }
}