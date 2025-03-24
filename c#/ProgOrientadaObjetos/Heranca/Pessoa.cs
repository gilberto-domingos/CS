namespace Heranca;

public class Pessoa
{
    private string nome;
    private int idade;
    
    public string Nome { get => nome; set => nome = value; }
    public int Idade { get => idade; set => idade = value; }

    protected void mensagemPessoa()
    {
        Console.WriteLine("Nome : " + nome);
        Console.WriteLine("Idade : " + idade);
    }
}