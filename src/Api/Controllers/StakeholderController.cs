using Application.DTOs.StakeholderDto;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StakeholderController : ControllerBase
{
    private readonly IStakeholderService _stakeholderService;

    public StakeholderController(IStakeholderService stakeholderService)
    {
        _stakeholderService = stakeholderService;
    }

    [HttpGet]
    public async Task<IActionResult> GetStakeholdersAsync()
    {
        var stakeholders = await _stakeholderService.GetStakeholdersAsync();

        return Ok(stakeholders);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetStakeholderByIdAsync(int id)
    {
        var stakeholder = await _stakeholderService.GetStakeholderByIdAsync(id);

        return Ok(stakeholder);
    }

    [HttpPost]
    public async Task<IActionResult> CreateStakeholderAsync([FromBody] CreateStakeholderDto stakeholderDto)
    {
        var stakeholder = await _stakeholderService.CreateStakeholderAsync(stakeholderDto);

        return Ok(stakeholder);
    }
}
