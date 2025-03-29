using FactoryMethod.ConcreteCreator;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        CartaoFactory cartaoFactory = null;
        Console.WriteLine("Digite o tipo de cartão que você gostaria de obter : ");
        string console = Console.ReadLine()?.ToLower();

        switch (console.ToLower())
        {
            case "black":
                cartaoFactory = new BlackFactory(50000, 0);
                break;
            case "titanium":
                cartaoFactory = new TitaniumFactory(100000, 500);
                break;
            case "platinum":
                cartaoFactory = new PlatinumFactory(500000, 1000);
                break;
            default:
                Console.WriteLine("Tipo de cartão inválido.");
                return;
        }

        CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();
        Console.WriteLine("Tipo do Cartao: {0}\nCrédito limite: {1}\nCobrança Anual: {2}",
            cartaoCredito.TipoCartao, cartaoCredito.LimiteCredito, cartaoCredito.CobrancaAnual);
        Console.ReadKey();
    }
}