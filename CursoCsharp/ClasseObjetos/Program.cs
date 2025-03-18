namespace ClasseObjetos;

class Program
{
    static void Main(string[] args)
    {
        CarrinhoItem tenis = new CarrinhoItem();
        tenis.Nome = "Tenis de corrida";
        tenis.Quantidade = 3;
        tenis.Preco = 999.99M;
        tenis.ImprimirItens();
        
        CarrinhoItem bola = new CarrinhoItem();
        bola.Nome = "Bola de futebol";
        bola.Quantidade = 1;
        bola.Preco = 99.00M;
        bola.ImprimirItens();

        CarrinhoItem camisa = new CarrinhoItem();
        camisa.Nome = "Camisa Polo";
        camisa.Quantidade = 2;
        camisa.Preco = 89.00M; 
        camisa.ImprimirItens();
    }

}