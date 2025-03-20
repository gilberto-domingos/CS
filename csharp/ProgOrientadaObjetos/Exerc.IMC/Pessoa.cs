using System.Reflection.PortableExecutable;
using System.Security;

namespace Exerc.IMC;

public class Pessoa
{
    private double altura;
    private double peso;
    
    public double Altura
    {
        get => altura;
        set => altura = value;
    }
    
    public double Peso
    {
        get => peso;
        set => peso = value;
    }

    public double calcularImc()
    {
      double imc = peso / (altura * altura); 
      
      if(imc <= 1.85)
      {
          Console.WriteLine("Voce está abaixo do peso ");
      }
      else if(imc <= 18)
      {
          Console.WriteLine("Seu peso está normal");
      }
      else if (imc >= 30)
      {
          Console.WriteLine("Você está acima do peso!");
      }
      else if(imc >= 40)
      {
          Console.WriteLine("Você está obeso !");
      }
      else
      {
          Console.WriteLine("Muito obeso ! Procure um Médico !");
      }
      return imc;
    }
}