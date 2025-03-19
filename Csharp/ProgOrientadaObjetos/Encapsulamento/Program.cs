using System.Xml.Serialization;

namespace Encapsulamento;

class Program
{
    static void Main(string[] args)
    {
        CarrinhoItem brinquedo = new CarrinhoItem();
        brinquedo.Nome = "AquaMan";
        brinquedo.Quantidade = 4;
        brinquedo.Preco = 250.85M;
        brinquedo.ImprimirItens();
        
        CarrinhoItem sapato = new CarrinhoItem();
        sapato.Nome = "Sapato Social";
        sapato.Quantidade = 2;
        sapato.Preco = 350.99M;
        sapato.ImprimirItens();
        
        
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