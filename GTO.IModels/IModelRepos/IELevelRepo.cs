using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface IELevelRepo
{
    Task AddAsync(ELevel item);
    Task UpdateAsync(ELevel item);
    Task DeleteAsync(int id);
    Task DeleteAsync(ELevel item);
    Task<ELevel?> GetByIdAsync(int id);
    Task<List<ELevel>> GetAllAsync();

}
