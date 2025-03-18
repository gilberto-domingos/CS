namespace ProgOrientObjeto;

class Program
{
    static void Main(string[] args)
    {
        
        CarrinhoItem bola = new CarrinhoItem();
        bola.nome = "Bola de futebol";
        bola.quantidade = 1;
        bola.preco = 99.00M;
        
        CarrinhoItem camisa = new CarrinhoItem();
        camisa.nome = "Camisa Polo";
        camisa.quantidade = 2;
        camisa.preco = 89.00M;
    }
}