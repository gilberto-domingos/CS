using FacadePattern.Interface;

namespace FacadePattern;

public class FornecedorPao : IPao
{
    public void BuscarPaoDeAlho()
    {
        Console.WriteLine("Buscando o pão de alho.");
    }

    public void BuscarPaoDeAlhoComQueijo()
    {
        ObterQueijo();
        Console.WriteLine("Buscando o pão de Alho Com Queijo.");
    }

    private void ObterQueijo()
    {
        Console.WriteLine("Obtendo queijo.");
    }
    
}