using DecoratorPattern.Interfaces;

namespace DecoratorPattern;

public class Pizza : IPizza
{
    public string BuscarTipoPizza()
    {
        var pizza = "Essa é uma pizza normal";
        return pizza;
    }
}