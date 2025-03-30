using AbstractFactory.Interfaces;

namespace AbstractFactory;
// Cliente
public class ClienteTelefoneCelular
{
    ISmartPhone smartPhone;
    ITelefoneNormal telefoneNormal;

    public ClienteTelefoneCelular(ITelefoneCelular telefoneFactory)
    {
         smartPhone = telefoneFactory.BuscarSmartPhone();
         telefoneNormal = telefoneFactory.BuscarTelefoneNormal();
    }

    public string BuscarSmartPhoneModeloDetalhes()
    {
        return smartPhone.BuscarDetalhesModelo();
    }

    public string BuscarTelefoneNormalModeloDetalhes()
    {
        return telefoneNormal.BuscarDetalhesModelo();
    }
}