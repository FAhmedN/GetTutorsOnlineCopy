using GTO.EntityModel.Entities;
using GTO.IModels.IModelRepos;
using GTO.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.Infrastructure.Repositories;

public class AssessmentMonthRepo : IAssessmentMonthRepo
{
    private readonly GTODbContext _context;

    public AssessmentMonthRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();
    }

    public async Task AddAsync(AssessmentMonth item)
    {
        _context.AssessmentsMonth.Add(item);
        await _context.SaveChangesAsync();

    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(AssessmentMonth item)
    {
        throw new NotImplementedException();
    }

    public async Task<List<AssessmentMonth>> GetAllAsync()
    {
        return await _context.AssessmentsMonth.ToListAsync();

    }

    public async Task<AssessmentMonth?> GetByIdAsync(int id)
    {
        return await _context.AssessmentsMonth.Where(m => m.Id== id).FirstOrDefaultAsync(); 

    }

    public async Task UpdateAsync(AssessmentMonth item)
    {
        _context.Entry(item).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
