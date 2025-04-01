namespace ObserverPattern.Interfaces;

public interface IObserver
{
    void Atualizar(ISubject subject);
}