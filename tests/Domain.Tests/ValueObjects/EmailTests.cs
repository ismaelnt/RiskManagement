using Domain.Exceptions;
using Domain.ValueObjects;

namespace Domain.Tests.ValueObjects;

public class EmailTests
{
    [Fact]
    public void ShouldReturnExceptionWhenEmailIsInvalid()
    {
        try
        {
            var email = new Email("invalid_email");
            Assert.Throws<InvalidEmailException>(() => email);
        }
        catch (InvalidEmailException)
        {
            Assert.True(true);
        }
    }

    [Fact]
    public void ShouldNotReturnExceptionWhenEmailIsValid()
    {
        try
        {
            var email = new Email("ismaelnt97@gmail.com");
            if (email != null)
                Assert.True(true);
        }
        catch (InvalidEmailException)
        {
            Assert.True(false);
        }
    }
}
