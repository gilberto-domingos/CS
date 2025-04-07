using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple;

public class EmailService : IEmailService
{
    public void Send(string to, string subject, string body)
    {
        Console.WriteLine($"\nEnviando E-MAIL real para: {to}");
        Console.WriteLine($"Assunto: {subject}");
        Console.WriteLine($"Corpo: {body}");
    }
}