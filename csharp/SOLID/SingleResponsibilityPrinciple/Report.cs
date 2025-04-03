namespace SingleResponsibilityPrinciple;

public class Report
{
    private string _title;
    private string _content;

    public Report(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public string Title
    {
        get => _title;
        private set => _title = string.IsNullOrWhiteSpace(value) 
            ? throw new ArgumentException("O título do relatório não pode ser vazio.") 
            : value;
    }

    public string Content
    {
        get => _content;
        private set => _content = string.IsNullOrWhiteSpace(value) 
            ? throw new ArgumentException("O conteúdo do relatório não pode ser vazio.") 
            : value;
    }

    public void Generate()
    {
        Console.WriteLine("Gerando relatório...");
        Console.WriteLine($"Título: {Title}");
        Console.WriteLine($"Conteúdo: {Content}");
    }
}