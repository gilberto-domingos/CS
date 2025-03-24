namespace This;

public class Pessoa
{
    private string nome = "Daniela";

    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}