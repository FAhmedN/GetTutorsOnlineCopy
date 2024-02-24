using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface ICoordinatorRepo
{
    Task AddAsync(Coordinator item);
    Task UpdateAsync(Coordinator item);
    Task DeleteAsync(int id);
    Task DeleteAsync(Coordinator item);
    Task<Coordinator?> GetByIdAsync(int id);
    Task<List<Coordinator>> GetAllAsync();

}
