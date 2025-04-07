using Domain.BackOffice.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Test.BackOficce.ValueObject;

[TestClass]
public class EmailTest
{
    [TestMethod]
    public void Falhar_email_nulo()
    {
        // Act & Assert
        var ex = Assert.ThrowsException<ArgumentException>(() => new Email(null));
        Assert.AreEqual("O endereço de email não pode ser nulo ou vazio.", ex.Message);
    }

    [TestMethod]
    public void Falhar_email_vazio()
    {
        // Act & Assert
        var ex = Assert.ThrowsException<ArgumentException>(() => new Email(""));
        Assert.AreEqual("O endereço de email não pode ser nulo ou vazio.", ex.Message);
    }

    [TestMethod]
    public void Passar_email_valido()
    {
        // Arrange
        var address = "jrdomingosjr00@gmail.com";

        // Act
        var email = new Email(address);

        // Assert
        Assert.IsNotNull(email);
        Assert.AreEqual(address, email.Address);
    }
    
}