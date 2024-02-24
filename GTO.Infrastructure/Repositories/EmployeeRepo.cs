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

public class EmployeeRepo : IEmployeeRepo
{
    private readonly GTODbContext _context;

    public EmployeeRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();
    }

    public Task AddAsync(Employee item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Employee item)
    {
        throw new NotImplementedException();
    }

    public Task<List<Employee>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Employee?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Employee item)
    {
        throw new NotImplementedException();
    }
}
