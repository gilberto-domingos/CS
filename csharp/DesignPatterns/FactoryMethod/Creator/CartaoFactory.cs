using FactoryMethod.Product;

namespace FactoryMethod.Creator;

public abstract class CartaoFactory
{
    public abstract CartaoCredito BuscarCartaoCredito();
}