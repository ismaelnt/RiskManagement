namespace Application.DTOs.StakeholderDto;

public class ResponseStakeholderDto
{
    public ResponseStakeholderDto(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; }
    public string Name { get; }
}
