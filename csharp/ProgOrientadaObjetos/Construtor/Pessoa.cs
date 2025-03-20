namespace Construtor;

public class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Pessoa Construtor executado");
    }

    public Pessoa(String nome)
    {
        Console.WriteLine("Olá" + nome);
    }
}