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

public class ELevelRepo : IELevelRepo
{
    private readonly GTODbContext _context;

    public ELevelRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();
    }

    public Task AddAsync(ELevel item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(ELevel item)
    {
        throw new NotImplementedException();
    }

    public Task<List<ELevel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ELevel?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ELevel item)
    {
        throw new NotImplementedException();
    }
}
