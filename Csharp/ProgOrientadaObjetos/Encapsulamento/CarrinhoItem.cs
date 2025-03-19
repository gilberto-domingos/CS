namespace Encapsulamento;
//***** POO - Encapsulamento *****//
public class CarrinhoItem
{
    private string nome;
    private int quantidade;
    private decimal preco;
    
    public string Nome { get => nome; set => nome = value; }
    public int Quantidade { get => quantidade; set => quantidade = value; }
    public decimal Preco { get => preco; set => preco = value; }

    public void ImprimirItens()
    {
        Console.WriteLine($"Nome: {nome}, Quantidade: {quantidade}, Valor: {preco}");
    }
    
    /* publicos
    public string nome { get; set; }
    public int quantidade { get; set; }
    public decimal preco { get; set; } */
}