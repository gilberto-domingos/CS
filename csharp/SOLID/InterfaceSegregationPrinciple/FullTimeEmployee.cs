namespace InterfaceSegregationPrinciple;

public class FullTimeEmployee : ISalaryCalculator, IBenefitsCalculator
{
    public string Name { get; set; }
    public decimal BaseSalary { get; set; }

    public FullTimeEmployee(string name, decimal baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }

    public decimal CalculateSalary()
    {
        decimal inss = BaseSalary * 0.11m; // alíquota simplificada de 11%
        decimal vt = BaseSalary * 0.06m;   // 6% de vale transporte
        decimal vr = 20 * 22;              // R$20 por 22 dias úteis

        decimal salary = BaseSalary - inss - vt - vr;
        
        Console.WriteLine($"[CLT] {Name} - Salário líquido: R${salary:F2}");
        return salary;
    }

    public decimal CalculateBenefits()
    {
        decimal fgts = BaseSalary * 0.08m;
        Console.WriteLine($"[CLT] {Name} - FGTS: R${fgts:F2}");
        return fgts;
    }
}