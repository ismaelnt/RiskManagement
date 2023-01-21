namespace Domain.Entities;

public abstract class Entity
{
    public int Id { get; }
    public DateTime CreatedAt { get; }
    public DateTime? UpdatedAt { get; }
}
