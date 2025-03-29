using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator;

public class BlackFactory : CartaoFactory
{
    private int _limiteCredito;
    private int _cobrancaAnual;

    public BlackFactory(int limiteCredito, int cobrancaAnual)
    {
        this._limiteCredito = limiteCredito;
        this._cobrancaAnual = cobrancaAnual;
    }
    
    public override CartaoCredito BuscarCartaoCredito()
    {
        return new CartaoBlack(_limiteCredito, _cobrancaAnual);
    }
}