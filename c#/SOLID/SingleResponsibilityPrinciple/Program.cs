namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportManager manager = new ReportManager();
            manager.ProcessReport("Relatório de Vendas", "Vendas aumentaram 15% neste mês.");
        }
    }
}