using System.Security;

namespace Exerc.IMC;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        p1.Altura = 1.70;
        p1.Peso = 80.72;
        double imc1 = p1.calcularImc();
        Console.WriteLine($"IMC (usando propriedades): {imc1:F2}");
    }
}