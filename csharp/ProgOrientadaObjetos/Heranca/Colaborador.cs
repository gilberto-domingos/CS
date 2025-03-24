namespace Heranca;

public class Colaborador : Pessoa
{
    private double salario;

    public double Salario { get => salario; set => salario = value; }

    public Colaborador(string nome, int idade, double salario)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Salario = salario;
        
        mensagemPessoa();
        mensagemColaborador();
    }
        
    private void mensagemColaborador()
    {
        Console.WriteLine("Salário : " + salario);
    }
}