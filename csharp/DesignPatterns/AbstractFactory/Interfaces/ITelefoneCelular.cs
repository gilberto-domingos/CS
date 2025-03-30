namespace AbstractFactory.Interfaces;
// Abstract Factory
public interface ITelefoneCelular
{
    ISmartPhone BuscarSmartPhone();
    
    ITelefoneNormal BuscarTelefoneNormal();
}