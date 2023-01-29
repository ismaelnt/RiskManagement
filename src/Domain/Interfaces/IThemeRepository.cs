using Domain.Entities;

namespace Domain.Interfaces;

public interface IThemeRepository
{
    Task<IEnumerable<Theme>> GetThemesAsync();
}
