using ObserverPattern.Interfaces;

namespace ObserverPattern;

public class NovasAgenciasNoticias : IObserver
{
    public string NomeAgencia { get; set; }

    public NovasAgenciasNoticias(string nomeAgencia)
    {
        this.NomeAgencia = nomeAgencia;
    }
    public void Atualizar(ISubject subject)
    {
        if (subject is EstacaoMeteorologica estacaoMeteorologica)
        {
            Console.WriteLine(string.Format("{0} reportando a temperatura {1} graus celsius", NomeAgencia, estacaoMeteorologica.Temperatura));
            Console.WriteLine();
        }
    }
}