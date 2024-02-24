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

public class RegionRepo : IRegionRepo
{
    private readonly GTODbContext _context;

    public RegionRepo(IDbContextFactory<GTODbContext> factory)
    {
        _context = factory.CreateDbContext();

    }

    public async Task AddAsync(Region item)
    {
        _context.Regions.Add(item);
        await _context.SaveChangesAsync();

    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Region item)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Region>> GetAllAsync()
    {
        return await _context.Regions.ToListAsync();

    }

    public async Task<Region?> GetByIdAsync(int id)
    {
        var reg = await _context.Regions.Where(r => r.Id == id).FirstOrDefaultAsync();
        return reg;
    }

    public async Task UpdateAsync(Region item)
    {
        _context.Entry(item).State = EntityState.Modified;
        await _context.SaveChangesAsync();

    }
}
