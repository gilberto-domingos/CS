namespace ApiRestFull.Relatorios;

internal static class Lista
{
    public static List<SolicitacaoRelatorios> Relatorios = new();
}

public class SolicitacaoRelatorios()
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Status { get; set; }
    public DateTime? ProcessedTime { get; set; }
}