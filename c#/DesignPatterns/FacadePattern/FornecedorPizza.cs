using FacadePattern.Interface;

namespace FacadePattern;

public class FornecedorPizza  : IPizza
{
    public void BuscarPizzaNormal()
    {
        ObterCoberturaNaoVegana();
        Console.WriteLine("Buscando a pizza normal.");
    }

    public void BuscarPizzaVegana()
    {
        Console.WriteLine("Buscando a pizza vegana.");
    }

    private void ObterCoberturaNaoVegana()
    {
        Console.WriteLine("Obtendo coberturas de pizzas não vegetais.");
    }
}