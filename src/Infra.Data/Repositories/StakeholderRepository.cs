using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories;

public class StakeholderRepository : IStakeholderRepository
{
    private readonly AppDbContext _dbContext;

    public StakeholderRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Stakeholder>> GetAsync()
    {
        return await _dbContext.Stakeholders.AsNoTracking().ToListAsync();
    }

    public async Task<Stakeholder?> GetByIdAsync(int id)
    {
        return await _dbContext.Stakeholders.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Stakeholder> CreateAsync(Stakeholder stakeholder)
    {
        _dbContext.Stakeholders.Add(stakeholder);
        await _dbContext.SaveChangesAsync();
        return stakeholder;
    }

    public async Task<Stakeholder> UpdateAsync(int id, Stakeholder stakeholder)
    {
        var stakeholderToUpdate = await _dbContext.Stakeholders.FindAsync(id);

        if (stakeholderToUpdate is null)
        {
            throw new Exception("Stakeholder not found");
        }

        _dbContext.Stakeholders.Update(stakeholder);
        await _dbContext.SaveChangesAsync();
        return stakeholder;
    }
}
