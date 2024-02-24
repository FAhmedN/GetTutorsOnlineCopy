using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface IManagerRepo
{
    Task AddAsync(Manager item);
    Task UpdateAsync(Manager item);
    Task DeleteAsync(int id);
    Task DeleteAsync(Manager item);
    Task<Manager?> GetByIdAsync(int id);
    Task<List<Manager>> GetAllAsync();

}
