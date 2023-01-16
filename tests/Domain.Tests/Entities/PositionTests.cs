using Domain.Entities;
using Domain.Exceptions;

namespace Domain.Tests.Entities;

public class PositionTests
{
    [Fact]
    public void ShouldCreatePosition()
    {
        var theme = new Position("Test Position");

        Assert.Equal("Test Position", theme.Name);
    }

    [Fact]
    public void ShouldNotCreatePositionWithEmptyName()
    {
        Assert.Throws<InvalidNameException>(() => new Position(""));
    }

    [Fact]
    public void ShouldNotCreatePositionWithNullName()
    {
        Assert.Throws<InvalidNameException>(() => new Position(null!));
    }

    [Fact]
    public void ShouldNotCreatePositionWithTwoCharactersName()
    {
        Assert.Throws<InvalidNameException>(() => new Position("12"));
    }

    [Fact]
    public void ShouldNotCreatePositionWithMoreThanFiftyCharactersName()
    {
        Assert.Throws<InvalidNameException>(() => new Position("123456789012345678901234567890123456789012345678901"));
    }
}
