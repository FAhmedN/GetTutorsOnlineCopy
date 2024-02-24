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

public class CoordinatorRepo : ICoordinatorRepo
{
    private readonly GTODbContext _context;

    public CoordinatorRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();
    }

    public Task AddAsync(Coordinator item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Coordinator item)
    {
        throw new NotImplementedException();
    }

    public Task<List<Coordinator>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Coordinator?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Coordinator item)
    {
        throw new NotImplementedException();
    }
}
