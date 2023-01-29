using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ThemeController : ControllerBase
{
    private readonly IThemeService _themeService;

    public ThemeController(IThemeService themeService)
    {
        _themeService = themeService;
    }

    [HttpGet]
    public async Task<IActionResult> GetThemesAsync()
    {
        var themes = await _themeService.GetThemesAsync();

        return Ok(themes);
    }
}
