namespace GetSet;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Roberto";
        Console.WriteLine(p1.Nome);
    }
}