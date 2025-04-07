using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple;

public class FakeEmailService : IEmailService
{
    public void Send(string to, string subject, string body)
    {
        Console.WriteLine($"\n[FAKE] Envio de email simulado para: {to}");
        Console.WriteLine($"[FAKE] Assunto: {subject}");
        Console.WriteLine($"[FAKE] Corpo: {body}");
    }
}