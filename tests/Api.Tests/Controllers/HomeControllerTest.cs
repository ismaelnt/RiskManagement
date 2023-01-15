using Microsoft.AspNetCore.Mvc;

namespace Api.Tests.Controllers;

public class HomeController
{
    [Fact]
    public void ShouldReturnStatusCode200()
    {
        var controller = new Api.Controllers.HomeController();
        var result = controller.Get() as OkResult;

        Assert.Equal(200, result?.StatusCode);
    }
}
