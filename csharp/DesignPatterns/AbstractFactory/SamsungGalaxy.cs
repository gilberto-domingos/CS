using AbstractFactory.Interfaces;

namespace AbstractFactory;
// ProdutoA2
public class SamsungGalaxy : ISmartPhone
{
    public string BuscarDetalhesModelo()
    {
        return "Modelo: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
    }
}