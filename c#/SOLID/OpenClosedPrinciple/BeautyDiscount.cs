namespace OpenClosedPrinciple;

public class BeautyDiscount : Discount
{
    public override decimal Calculate(decimal price) => price * 0.5m;
}