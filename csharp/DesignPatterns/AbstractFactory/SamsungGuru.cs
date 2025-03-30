using AbstractFactory.Interfaces;

namespace AbstractFactory;
// ProdutoB2
public class SamsungGuru : ITelefoneNormal
{
    public string BuscarDetalhesModelo()
    {
        return "Modelo: Samsung Guru\nRAM: NA\nCamera: NA\n";
    }
}