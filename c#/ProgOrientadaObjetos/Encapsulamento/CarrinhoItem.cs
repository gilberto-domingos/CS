namespace Encapsulamento;
//***** POO - Encapsulamento *****//
public class CarrinhoItem
{
    private string _nome;
    private int _quantidade;
    private decimal _preco;
    
    public string Nome { get => _nome; set => _nome = value; }
    public int Quantidade { get => _quantidade; set => _quantidade = value; }
    public decimal Preco { get => _preco; set => _preco = value; }

    public void ImprimirItens()
    {
        Console.WriteLine($"Nome: {_nome}, Quantidade: {_quantidade}, Valor: {_preco}");
    }
}
