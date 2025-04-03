namespace SingleResponsibilityPrinciple
{
    public class ReportManager
    {
        private readonly ReportRepository _repository;
        private readonly PrintService _printService;

        public ReportManager()
        {
            _repository = new ReportRepository();
            _printService = new PrintService();
        }

        public void ProcessReport(string title, string content)
        {
            Report report = new Report(title, content);
            report.Generate();  // Gera o relatório
            _repository.Save(report);  // Salva o relatório
            _printService.Print(report);  // Imprime o relatório
        }
    }
}