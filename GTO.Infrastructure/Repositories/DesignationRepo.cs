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

public class DesignationRepo : IDesignationRepo
{
    private readonly GTODbContext _context;

    public DesignationRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();
    }

    public Task AddAsync(Designation item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Designation item)
    {
        throw new NotImplementedException();
    }

    public Task<List<Designation>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Designation?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Designation item)
    {
        throw new NotImplementedException();
    }
}
