using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcretesFactory;
// ConcreteFactory1
public class Nokia : ITelefoneCelular
{
    public ISmartPhone BuscarSmartPhone()
    {
        return new NokiaPixel();
    }

    public ITelefoneNormal BuscarTelefoneNormal()
    {
        return new Nokia1600();
    }
}