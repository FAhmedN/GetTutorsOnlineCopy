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


public class RatingItemRepo : IRatingItemRepo
{
    private readonly GTODbContext _context;

    public RatingItemRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();

    }

    public Task AddAsync(RatingItem item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(RatingItem item)
    {
        throw new NotImplementedException();
    }

    public Task<List<RatingItem>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<RatingItem?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(RatingItem item)
    {
        throw new NotImplementedException();
    }
}
