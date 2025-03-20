namespace GetSet;

public class Pessoa
{
    private string nome;
    
    // modo lambda, mais limpo e legível.
    public string Nome { get => nome; set => nome = value; }

    
    /* modo básico padrão
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    } */
}