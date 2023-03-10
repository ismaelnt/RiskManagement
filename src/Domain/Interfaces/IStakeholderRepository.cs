using Domain.Entities;

namespace Domain.Interfaces;

public interface IStakeholderRepository
{
    Task<IEnumerable<Stakeholder>> GetAsync();
    Task<Stakeholder?> GetByIdAsync(int id);
    Task<Stakeholder> CreateAsync(Stakeholder stakeholder);
    Task<Stakeholder> UpdateAsync(int id, Stakeholder stakeholder);
}
