using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories;

public class InstitutionRepository : IInstitutionRepository
{
    private readonly AppDbContext _context;

    public InstitutionRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Institution> CreateIfNotExistsAsync(Institution institution)
    {
        var institutionFromDb = await _context.Institutions.FirstOrDefaultAsync(i => i.Name == institution.Name);

        if (institutionFromDb is null)
        {
            institutionFromDb = new Institution(institution.Name);
            await _context.Institutions.AddAsync(institutionFromDb);
            await _context.SaveChangesAsync();
        }

        return institutionFromDb;
    }
}
