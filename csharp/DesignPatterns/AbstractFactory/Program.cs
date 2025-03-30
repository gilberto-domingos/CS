using AbstractFactory.ConcretesFactory;
using AbstractFactory.Interfaces;

namespace AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        ITelefoneCelular nokiaTelefone = new Nokia();
        ClienteTelefoneCelular nokiaCliente = new ClienteTelefoneCelular(nokiaTelefone);
        
        Console.WriteLine("*************** NOKIA ***************");
        Console.WriteLine(nokiaCliente.BuscarSmartPhoneModeloDetalhes());
        Console.WriteLine(nokiaCliente.BuscarTelefoneNormalModeloDetalhes());

        ITelefoneCelular samsungTelefone = new Samsung();
        ClienteTelefoneCelular samsungClient = new ClienteTelefoneCelular(samsungTelefone);

        Console.WriteLine("*************** SAMSUNG ***************");
        Console.WriteLine(samsungClient.BuscarSmartPhoneModeloDetalhes());
        Console.WriteLine(samsungClient.BuscarTelefoneNormalModeloDetalhes());

        Console.ReadKey();
    }
}