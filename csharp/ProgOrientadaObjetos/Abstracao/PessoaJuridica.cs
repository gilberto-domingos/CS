namespace Abstracao;

public class PessoaJuridica : Padrao
{
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo pessoa jurídica " + (valor * 0.2)) ;
    }
}