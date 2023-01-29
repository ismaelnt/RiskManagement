using Application.DTOs.ThemeDto;
using Domain.Entities;

namespace Application.Interfaces;

public interface IThemeService
{
    Task<IEnumerable<ReadThemesDto>> GetThemesAsync();
}
