using AbstractFactory.Interfaces;

namespace AbstractFactory;
// ProdutoA1
public class NokiaPixel : ISmartPhone
{
    public string BuscarDetalhesModelo()
    {
        return "Modelo: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
    }
}