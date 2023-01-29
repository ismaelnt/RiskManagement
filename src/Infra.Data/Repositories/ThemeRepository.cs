using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories;

public class ThemeRepository : IThemeRepository
{
    private readonly AppDbContext _context;

    public ThemeRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Theme>> GetThemesAsync()
    {
        var themes = await _context.Themes.AsNoTracking().ToListAsync();

        return themes;
    }
}
