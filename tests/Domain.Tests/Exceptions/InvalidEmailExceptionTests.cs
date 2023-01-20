using Domain.Exceptions;

namespace Domain.Tests.Exceptions;

public class InvalidEmailExceptionTests
{
    [Fact]
    public void InvalidEmailExceptionWithMessageShouldReturnMessage()
    {
        var message = "Invalid email";

        var exception = new InvalidEmailException(message);

        Assert.Equal(message, exception.Message);
    }
}
