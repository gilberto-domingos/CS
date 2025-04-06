namespace LiskovSubstitutionPrinciple;

class Program
{
    static void Main(string[] args)
    {
        BankAccount contaCorrente = new CheckingAccount("001-CC");
        contaCorrente.Deposit(200M);
        contaCorrente.Withdraw(600M);  // usa limite de crédito
        Console.WriteLine($"Conta Corrente ({contaCorrente.AccountNumber}) - Saldo: R${contaCorrente.Balance:F2}");

        BankAccount contaPoupanca = new SavingAccount("002-PP");
        contaPoupanca.Deposit(300M);
        contaPoupanca.Withdraw(150M);
        Console.WriteLine($"Conta Poupança ({contaPoupanca.AccountNumber}) - Saldo: R${contaPoupanca.Balance:F2}");
    }
}