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

public class ReportHeadRepo : IReportHeadRepo
{
    private readonly GTODbContext _context;

    public ReportHeadRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();

    }

    public Task AddAsync(ReportHead item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(ReportHead item)
    {
        throw new NotImplementedException();
    }

    public Task<List<ReportHead>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ReportHead?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ReportHead item)
    {
        throw new NotImplementedException();
    }
}
