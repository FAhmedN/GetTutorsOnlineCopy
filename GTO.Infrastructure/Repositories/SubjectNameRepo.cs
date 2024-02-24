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

public class SubjectNameRepo : ISubjectNameRepo
{
    private readonly GTODbContext _context;

    public SubjectNameRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();

    }

    public async Task AddAsync(SubjectName item)
    {
        _context.Subjects.Add(item);
        await _context.SaveChangesAsync();

    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(SubjectName item)
    {
        throw new NotImplementedException();
    }

    public async Task<List<SubjectName>> GetAllAsync()
    {
        return await _context.Subjects.ToListAsync();
    }

    public async Task<SubjectName?> GetByIdAsync(int id)
    {
        var subj = await _context.Subjects.Where(s => s.Id == id).FirstOrDefaultAsync();
        return subj;
    }

    public async Task UpdateAsync(SubjectName item)
    {
        _context.Entry(item).State = EntityState.Modified;
        await _context.SaveChangesAsync();

    }
}
