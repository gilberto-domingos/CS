namespace InterfaceSegregationPrinciple;

class Program
{
    static void Main(string[] args)
    {
        var clt = new FullTimeEmployee("João", 7500M);
        clt.CalculateSalary();
        clt.CalculateBenefits();

        Console.WriteLine();

        var pj = new ContractEmployee("Maria", 75M, 160);
        pj.CalculateSalary();
    }
}