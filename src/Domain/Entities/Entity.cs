namespace Domain.Entities;

public abstract class Entity
{
    public Entity()
    {
        CreatedAt = DateTime.Now;
    }
    public int Id { get; protected set; }
    public DateTime CreatedAt { get; }
    public DateTime? UpdatedAt { get; }
}
