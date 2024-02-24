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

public class ManagerRepo : IManagerRepo
{
    private readonly GTODbContext _context;

    public ManagerRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();
    }

    public Task AddAsync(Manager item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Manager item)
    {
        throw new NotImplementedException();
    }

    public Task<List<Manager>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Manager?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Manager item)
    {
        throw new NotImplementedException();
    }
}
