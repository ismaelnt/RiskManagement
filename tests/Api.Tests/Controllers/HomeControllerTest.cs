using Microsoft.AspNetCore.Mvc;

namespace Api.Tests.Controllers;

public class HomeController
{
    [Fact]
    public void Get_StatusCode_To_Check()
    {
        var controller = new Api.Controllers.HomeController();
        var result = controller.Get() as OkResult;

        Assert.Equal(200, result?.StatusCode);
    }
}
