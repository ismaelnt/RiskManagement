using Domain.Entities;
using Domain.Exceptions;

namespace Domain.Tests.Entities;

public class ThemeTests
{
    [Fact]
    public void ShouldCreateTheme()
    {
        var theme = new Theme("Test Theme");

        Assert.Equal("Test Theme", theme.Name);
    }

    [Fact]
    public void ShouldNotCreateThemeWithEmptyName()
    {
        Assert.Throws<InvalidNameException>(() => new Theme(""));
    }

    [Fact]
    public void ShouldNotCreateThemeWithNullName()
    {
        Assert.Throws<InvalidNameException>(() => new Theme(null!));
    }

    [Fact]
    public void ShouldNotCreateThemeWithTwoCharactersName()
    {
        Assert.Throws<InvalidNameException>(() => new Theme("12"));
    }

    [Fact]
    public void ShouldNotCreateThemeWithMoreThanFiftyCharactersName()
    {
        Assert.Throws<InvalidNameException>(() => new Theme("123456789012345678901234567890123456789012345678901"));
    }
}
