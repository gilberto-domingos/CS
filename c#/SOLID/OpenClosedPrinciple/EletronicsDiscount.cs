namespace OpenClosedPrinciple;

public class EletronicsDiscount : Discount
{
    public override decimal Calculate(decimal price) => price * 0.5m;
}