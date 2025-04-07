namespace DependencyInversionPrinciple;

class Program
{
    static void Main(string[] args)
    {
        var realEmailService = new EmailService();
        var fakeEmailService = new FakeEmailService();

        Console.WriteLine("Testando com serviço REAL:");
        var userService1 = new UserService(realEmailService);
        userService1.RegisterUser("João", "joao@email.com");

        Console.WriteLine("\n Testando com serviço FAKE:");
        var userService2 = new UserService(fakeEmailService);
        userService2.RegisterUser("Maria", "maria@email.com");
    }
}