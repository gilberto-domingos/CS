using AbstractFactory.Interfaces;

namespace AbstractFactory;
// ProdutoB1
public class Nokia1600 : ITelefoneNormal
{
    public string BuscarDetalhesModelo()
    {
        return "Modelo: Nokia 1600\nRAM: NA\nCamera: NA\n";
    }
}