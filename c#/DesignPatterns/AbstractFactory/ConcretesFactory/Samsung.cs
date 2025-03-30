using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcretesFactory;
// ConcreteFactory2
public class Samsung : ITelefoneCelular
{
    public ISmartPhone BuscarSmartPhone()
    {
        return new SamsungGalaxy();
    }

    public ITelefoneNormal BuscarTelefoneNormal()
    {
        return new SamsungGuru();
    }
}