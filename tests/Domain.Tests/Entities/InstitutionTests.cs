using Domain.Entities;
using Domain.Exceptions;

namespace Domain.Tests.Entities;

public class InstitutionTests
{
    [Fact]
    public void ShouldCreateInstitution()
    {
        var theme = new Institution("Test Institution");

        Assert.Equal("Test Institution", theme.Name);
    }

    [Fact]
    public void ShouldNotCreateInstitutionWithEmptyName()
    {
        Assert.Throws<InvalidNameException>(() => new Institution(""));
    }

    [Fact]
    public void ShouldNotCreateInstitutionWithNullName()
    {
        Assert.Throws<InvalidNameException>(() => new Institution(null!));
    }

    [Fact]
    public void ShouldNotCreateInstitutionWithTwoCharactersName()
    {
        Assert.Throws<InvalidNameException>(() => new Institution("12"));
    }

    [Fact]
    public void ShouldNotCreateInstitutionWithMoreThanFiftyCharactersName()
    {
        Assert.Throws<InvalidNameException>(
            () => new Institution("123456789012345678901234567890123456789012345678901"));
    }
}
