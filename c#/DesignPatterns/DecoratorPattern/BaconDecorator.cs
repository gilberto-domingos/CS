using DecoratorPattern.Interfaces;

namespace DecoratorPattern;
// Concrete Decorator
public class BaconDecorator : PizzaDecorator
{
    public BaconDecorator(IPizza pizza) : base(pizza)
    {
        
    }

    public override string BuscarTipoPizza()
    {
        var pizza = base.BuscarTipoPizza();
        pizza += "\r\n com extra de bacon";
        return pizza;
    }
}