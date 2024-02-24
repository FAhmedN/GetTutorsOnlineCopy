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

public class PresonnelRepo : IPersonnelRepo
{
    private readonly GTODbContext _context;

    public PresonnelRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();

    }

    public Task AddAsync(Personnel item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Personnel item)
    {
        throw new NotImplementedException();
    }

    public Task<List<Personnel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Personnel?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Personnel item)
    {
        throw new NotImplementedException();
    }
}
