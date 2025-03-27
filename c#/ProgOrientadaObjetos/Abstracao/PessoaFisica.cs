namespace Abstracao;

public class PessoaFisica : Padrao
{
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo pessoa fisica " + (valor * 0.1)) ;
    }
    
}