using System.Text.RegularExpressions;

namespace Domain.BackOffice.ValueObject;

public class Email
{
    public string Address { get; private set; }

    public Email(string address)
    {
        // Valida se o email está nulo ou vazio
        if (string.IsNullOrWhiteSpace(address))
        {
            throw new ArgumentException("O endereço de email não pode ser nulo ou vazio.");
        }

        // Valida o formato do email
        if (!IsValidEmail(address))
        {
            throw new ArgumentException("O endereço de email informado é inválido.");
        }

        Address = address;
    }

    private bool IsValidEmail(string email)
    {
        // Expressão regular simples para validação de e-mail
        var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);
        return regex.IsMatch(email);
    }

    public override string ToString() => Address;
}