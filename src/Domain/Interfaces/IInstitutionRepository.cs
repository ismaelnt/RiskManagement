using Domain.Entities;

namespace Domain.Interfaces;

public interface IInstitutionRepository
{
    Task<Institution> CreateIfNotExistsAsync(Institution institution);
}
