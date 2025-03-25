namespace Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        Imposto objEst = new Estagiario();
        objEst.valeAlimentacao(1000);
        objEst.valeTransporte(1000);
        Console.WriteLine("---------------------------------------------");
        
        Imposto objGer = new Gerente();
        objGer.valeAlimentacao(5000);
        objGer.valeTransporte(5000);
        Console.WriteLine("--------------------------------------------");

        Imposto objAten = new Atendente();
        objAten.valeAlimentacao(2000);
        objAten.valeTransporte(2000);
        Console.WriteLine("-------------------------------------------");
    }
}