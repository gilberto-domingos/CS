using Domain.BackOffice.ValueObject;

namespace Domain.BackOffice.Entity;

public class Customer
{
    public int Id { get; } = 0;
    public string Name { get; private set; }
    public Email Email { get; private set; }

    public Customer(int id, string name, Email email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    public void ChangeEmail(Email newEmail)
    {
        Email = newEmail;
    }
}