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

public class TeacherRepo : ITeacherRepo
{
    private readonly GTODbContext _context;

    public TeacherRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();

    }

    public Task AddAsync(Teacher item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Teacher item)
    {
        throw new NotImplementedException();
    }

    public Task<List<Teacher>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Teacher?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Teacher item)
    {
        throw new NotImplementedException();
    }
}
