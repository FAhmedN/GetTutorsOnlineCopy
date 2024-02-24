using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface IPersonnelRepo
{
    Task AddAsync(Personnel item);
    Task UpdateAsync(Personnel item);
    Task DeleteAsync(int id);
    Task DeleteAsync(Personnel item);
    Task<Personnel?> GetByIdAsync(int id);
    Task<List<Personnel>> GetAllAsync();

}
