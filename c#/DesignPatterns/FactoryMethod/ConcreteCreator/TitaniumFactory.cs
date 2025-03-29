using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator;

public class TitaniumFactory : CartaoFactory
{
    private int _limiteCredito;
    private int _cobrancaAnual;

    public TitaniumFactory(int limiteCredito, int cobrancaAnual)
    {
        this._limiteCredito = limiteCredito;
        this._cobrancaAnual = cobrancaAnual;
    }
    
    public override CartaoCredito BuscarCartaoCredito()
    {
        return new CartaoTitanium(_limiteCredito, _cobrancaAnual);
    }
}