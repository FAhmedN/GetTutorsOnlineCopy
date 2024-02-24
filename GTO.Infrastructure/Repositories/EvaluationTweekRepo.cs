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

public class EvaluationTweekRepo : IEvaluationTweekRepo
{
    private readonly GTODbContext _context;

    public EvaluationTweekRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();

    }

    public Task AddAsync(EvaluationTweak item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(EvaluationTweak item)
    {
        throw new NotImplementedException();
    }

    public Task<List<EvaluationTweak>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<EvaluationTweak?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(EvaluationTweak item)
    {
        throw new NotImplementedException();
    }
}
