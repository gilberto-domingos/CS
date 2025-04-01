using ObserverPattern.Interfaces;

namespace ObserverPattern;

public class EstacaoMeteorologica : ISubject
{
    private List<IObserver> observers;

    private float _temperatura;

    public float Temperatura
    {
        get { return _temperatura; }
        set { _temperatura = value; Notificar();}
    }

    public EstacaoMeteorologica()
    {
        this.observers = new List<IObserver>();
    }
    
    public void Anexar(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Notificar()
    {
        observers.ForEach(observer => observer.Atualizar(this));
    }
}