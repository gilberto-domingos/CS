namespace OpenClosedPrinciple;

class Program
{
    static void Main(string[] args)
    {
        var eletronics = new EletronicsDiscount();
        decimal finalPriceEletronics = eletronics.Calculate(20M);
        Console.WriteLine($"Preço final do eletrônico com desconto: R${finalPriceEletronics:F2}");

        var health = new HealthDiscount();
        decimal finalPriceHealth = health.Calculate(30M);
        Console.WriteLine($"Preço final do produto de saúde com desconto: R${finalPriceHealth:F2}");

        Discount beauty = new BeautyDiscount();
        decimal finalPriceBeauty = beauty.Calculate(35M);
        Console.WriteLine($"Preço final do produto de beleza com desconto: R${finalPriceBeauty:F2}");

        Discount fashion = new FashionDiscount();
        decimal finalPriceFashion = fashion.Calculate(25M);
        Console.WriteLine($"Preço final do produto de moda com desconto: R${finalPriceFashion:F2}");
    }
}