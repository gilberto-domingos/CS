using BuilderPattern.Interfaces;

namespace BuilderPattern;

public class DiretorCarro
{
    private IConstrutorCarro _construtorCarro;

    public DiretorCarro(IConstrutorCarro construtorCarro)
    {
        _construtorCarro = construtorCarro;
    }

    public void ConstruirCarro(string modelo, string marca, int ano)
    {
        _construtorCarro.ConstruirModelo(modelo);
        _construtorCarro.ConstruirMarca(marca);
        _construtorCarro.ConstruirAno(ano);
        
    }
}