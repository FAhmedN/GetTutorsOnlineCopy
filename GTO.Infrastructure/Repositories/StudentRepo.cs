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

public class StudentRepo : IStudentRepo
{
    private readonly GTODbContext _context;

    public StudentRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();

    }

    public Task AddAsync(Student item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Student item)
    {
        throw new NotImplementedException();
    }

    public Task<List<ReportItem>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Student?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Student item)
    {
        throw new NotImplementedException();
    }
}
