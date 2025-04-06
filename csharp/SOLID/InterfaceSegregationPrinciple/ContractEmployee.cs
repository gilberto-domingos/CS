namespace InterfaceSegregationPrinciple;

public class ContractEmployee : ISalaryCalculator
{
    public string Name { get; set; }
    public decimal HourlyRate { get; set; }
    public int WorkedHours { get; set; }

    public ContractEmployee(string name, decimal hourlyRate, int workedHours)
    {
        Name = name;
        HourlyRate = hourlyRate;
        WorkedHours = workedHours;
    }

    public decimal CalculateSalary()
    {
        decimal total = HourlyRate * WorkedHours;
        Console.WriteLine($"[PJ] {Name} - Total a receber: R${total:F2}");
        return total;
    }
}