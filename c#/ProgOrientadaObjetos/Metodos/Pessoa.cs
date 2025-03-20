namespace Metodos;

public class Pessoa
{
    public void apresentar()
    {
        Console.WriteLine("Apresentando a pessoa. Ele é o Marcos !");
    }
    
    public void apresentar(string nome)
    {
        Console.WriteLine("Apresentando a pessoa. Ele é o " +nome+ "!");
    }
    
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Apresentando a pessoa. Ele é o " +nome+ " ele tem " +idade+ " anos !");
    }
}