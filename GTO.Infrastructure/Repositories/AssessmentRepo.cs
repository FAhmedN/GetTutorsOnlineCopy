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

public class AssessmentRepo : IAssessmentRepo
{
    private readonly GTODbContext _context;

    public AssessmentRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();

    }

    public Task AddAsync(Assessment item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Assessment item)
    {
        throw new NotImplementedException();
    }

    public Task<List<Assessment>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Assessment?>> GetAllAsync(Teacher conductedBy)
    {
        throw new NotImplementedException();
    }

    public Task<List<Assessment?>> GetAllAsync(Student student)
    {
        throw new NotImplementedException();
    }

    public Task<Assessment?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Assessment item)
    {
        throw new NotImplementedException();
    }
}
