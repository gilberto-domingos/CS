namespace BuilderPattern;

class Program
{
    static void Main(string[] args)
    {
        var construtorCarro = new ConstrutorCarro();

        var diretorCarro = new DiretorCarro(construtorCarro);
        
        diretorCarro.ConstruirCarro("Sedan", "Honda", 2024);

        var meuCarro = construtorCarro.ObterCarro();
        
        Console.WriteLine($"Modelo: {meuCarro.Modelo} - Marca: {meuCarro.Marca} - Ano: {meuCarro.Ano}");
    }
}