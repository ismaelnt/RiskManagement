using Domain.ValueObjects;

namespace Domain.Tests.ValueObjects;

public class WebsiteTests
{
    [Theory]
    [InlineData("http://www.google.com")]
    [InlineData("https://www.google.com")]
    [InlineData("http://google.com")]
    [InlineData("https://google.com")]
    public void ShouldCreateWebsite(string url)
    {
        var website = new Website(url);
        Assert.Equal(url, website.Url);
    }

    [Fact]
    public void ShouldThrowExceptionWhenUrlIsInvalid()
    {
        Assert.Throws<ArgumentException>(() => new Website("invalid_url"));
    }
}
