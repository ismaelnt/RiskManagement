using Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Api.Tests.Controllers;

public class HealthControllerTest
{
    [Fact]
    public void ShouldReturnStatusCode200()
    {
        var controller = new HealthController();
        var result = controller.Get();
        Assert.IsType<OkObjectResult>(result);
    }
}
