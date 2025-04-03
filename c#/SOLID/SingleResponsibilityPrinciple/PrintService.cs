namespace SingleResponsibilityPrinciple
{
    public class PrintService
    {
        public void Print(Report report)
        {
            Console.WriteLine("🖨️ Imprimindo relatório...");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"📄 {report.Title}");
            Console.WriteLine(report.Content);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}