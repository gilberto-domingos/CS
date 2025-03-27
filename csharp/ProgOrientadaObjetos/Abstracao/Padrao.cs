namespace Abstracao;

public abstract class Padrao
{   
    public abstract void taxaEmprestimo(double valor);

    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança R$ " + (valor * taxa));
    }
}