namespace SingleResponsibilityPrinciple
{
    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Report(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public void Generate()
        {
            Console.WriteLine("Gerando Relatório...");
            Console.WriteLine($"Título: {Title}");
            Console.WriteLine($"Conteúdo: {Content}");
        }
    }
}