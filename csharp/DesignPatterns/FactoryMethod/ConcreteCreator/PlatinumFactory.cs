using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator;

public class PlatinumFactory : CartaoFactory
{
    private int _limiteCredito;
    private int _cobrancaAnual;

    public PlatinumFactory(int limiteCredito, int cobrancaAnual)
    {
        this._limiteCredito = limiteCredito;
        this._cobrancaAnual = cobrancaAnual;
    }
    
    public override CartaoCredito BuscarCartaoCredito()
    {
        return new CartaoPlatinum(_limiteCredito, _cobrancaAnual);
    }
}