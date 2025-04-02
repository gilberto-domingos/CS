using BuilderPattern.Interfaces;
// Concrete Builder
namespace BuilderPattern;

public class ConstrutorCarro : IConstrutorCarro
{
    private Carro _carro = new Carro();
    
    public void ConstruirModelo(string modelo)
    {
        _carro.Modelo = modelo;
    }

    public void ConstruirMarca(string marca)
    {
        _carro.Marca = marca; 
    }

    public void ConstruirAno(int ano)
    {
        _carro.Ano = ano;
    }

    public Carro ObterCarro()
    {
        return _carro;
    }
}