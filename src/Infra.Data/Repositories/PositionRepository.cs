using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories;

public class PositionRepository : IPositionRepository
{
    private readonly AppDbContext _context;

    public PositionRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Position> CreateIfNotExistsAsync(Position position)
    {
        var positionFromDb = await _context.Positions.FirstOrDefaultAsync(p => p.Name == position.Name);

        if (positionFromDb is null)
        {
            positionFromDb = new Position(position.Name);
            await _context.Positions.AddAsync(positionFromDb);
            await _context.SaveChangesAsync();
        }

        return positionFromDb;
    }
}
