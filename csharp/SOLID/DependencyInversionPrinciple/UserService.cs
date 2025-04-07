using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple;

public class UserService
{
    private readonly IEmailService _emailService;

    public UserService(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public void RegisterUser(string name, string email)
    {
        Console.WriteLine($"Usuário '{name}' cadastrado com sucesso!");

        string subject = "Bem-vindo ao sistema!";
        string body = $"Olá {name}, seu cadastro foi realizado com sucesso.";

        _emailService.Send(email, subject, body);
    }
}