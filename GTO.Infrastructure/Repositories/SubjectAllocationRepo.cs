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

public class SubjectAllocationRepo : ISubjectAllocationRepo
{
    private readonly GTODbContext _context;

    public SubjectAllocationRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();

    }

    public Task AddAsync(SubjectAllocation item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(SubjectAllocation item)
    {
        throw new NotImplementedException();
    }

    public Task<List<SubjectAllocation>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SubjectAllocation?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(SubjectAllocation item)
    {
        throw new NotImplementedException();
    }
}
