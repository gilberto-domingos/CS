namespace OpenClosedPrinciple;

public class HealthDiscount : Discount
{
    public override decimal Calculate(decimal price) => price * 0.5m;
}