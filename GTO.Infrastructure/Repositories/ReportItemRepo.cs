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

public class ReportItemRepo : IReportItemRepo
{
    private readonly GTODbContext _context;

    public ReportItemRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();

    }

    public Task AddAsync(ReportItem item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(ReportItem item)
    {
        throw new NotImplementedException();
    }

    public Task<List<ReportItem>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ReportItem?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ReportItem item)
    {
        throw new NotImplementedException();
    }
}
