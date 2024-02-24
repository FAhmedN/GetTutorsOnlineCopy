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

public class DayNameRepo : IDayNameRepo
{
    private readonly GTODbContext _context;

    public DayNameRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();
    }

    public Task AddAsync(DayName item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(DayName item)
    {
        throw new NotImplementedException();
    }

    public Task<List<DayName>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<DayName?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(DayName item)
    {
        throw new NotImplementedException();
    }
}
