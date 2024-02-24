using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface IRegionRepo
{
    Task AddAsync(Region item);
    Task UpdateAsync(Region item);
    Task DeleteAsync(int id);
    Task DeleteAsync(Region item);
    Task<Region?> GetByIdAsync(int id);
    Task<List<Region>> GetAllAsync();

}
