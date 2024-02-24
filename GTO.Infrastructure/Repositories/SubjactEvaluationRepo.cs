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

public class SubjactEvaluationRepo : ISubjectEvaluationRepo
{
    private readonly GTODbContext _context;

    public SubjactEvaluationRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context=factory.CreateDbContext();

    }

    public Task AddAsync(SubjectEvaluation item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(SubjectEvaluation item)
    {
        throw new NotImplementedException();
    }

    public Task<List<SubjectEvaluation>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SubjectEvaluation?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(SubjectEvaluation item)
    {
        throw new NotImplementedException();
    }
}
