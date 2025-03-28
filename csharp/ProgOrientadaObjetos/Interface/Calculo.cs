namespace Interface;

public class Calculo : IPadrao
{
    public void somar(int n1, int n2)
    {
        Console.WriteLine(" A soma é " + (n1 + n2));
    }

    public void subtrair(int n1, int n2)
    {
        Console.WriteLine("A subtração é " + (n1 - n2));
    }

    public void multiplicar(int n1, int n2)
    {
        Console.WriteLine("A multiplicação é " + (n1 * n2));
    }
}