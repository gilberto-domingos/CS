namespace Interface;

class Program
{
    static void Main(string[] args)
    {
        Calculo calculo = new Calculo();
        calculo.somar(15,35);
        calculo.subtrair(85,35);
        calculo.multiplicar(16,25);
    }
}