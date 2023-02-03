using Domain.Entities;

namespace Domain.Interfaces;

public interface IPositionRepository
{
    Task<Position> CreateIfNotExistsAsync(Position position);
}
