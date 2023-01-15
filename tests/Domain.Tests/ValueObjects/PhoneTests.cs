using Domain.Exceptions;
using Domain.ValueObjects;

namespace Domain.Tests.ValueObjects;

public class PhoneTests
{
    [Fact]
    public void ShouldReturnExceptionWhenPhoneIsInvalid()
    {
        try
        {
            var phone = new Phone("81983595962");
            Assert.Throws<InvalidPhoneException>(() => phone);
        }
        catch (InvalidPhoneException)
        {
            Assert.True(true);
        }
    }

    [Fact]
    public void ShouldNotReturnExceptionWhenPhoneIsValid()
    {
        try
        {
            var phone = new Phone("(81) 98359-5962");
            if (phone != null)
                Assert.True(true);
        }
        catch (InvalidPhoneException)
        {
            Assert.True(false);
        }
    }
}
