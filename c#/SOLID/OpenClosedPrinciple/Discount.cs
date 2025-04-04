namespace OpenClosedPrinciple;
// enum não foi usado, só incentivo uso de boas práticas
public enum EProductType
{
    Eletronics = 1,
    Health = 2,
    Beauty = 3,
    Fashion = 4 
}

public abstract class Discount
{
    public abstract decimal Calculate(decimal price);
}

