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

public class ParentRepo : IParentRepo
{
    private readonly GTODbContext _context;

    public ParentRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();

    }

    public Task AddAsync(Parent item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Parent item)
    {
        throw new NotImplementedException();
    }

    public Task<List<Parent>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<EvaluationTweak?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Parent item)
    {
        throw new NotImplementedException();
    }
}
