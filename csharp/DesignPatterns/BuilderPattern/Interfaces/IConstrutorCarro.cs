namespace BuilderPattern.Interfaces;
// Builder
public interface IConstrutorCarro
{
    void ConstruirModelo(string modelo);
    void ConstruirMarca(string marca);
    void ConstruirAno(int ano);
    Carro ObterCarro();
}