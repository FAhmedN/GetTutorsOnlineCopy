using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface IDayNameRepo
{
    Task AddAsync(DayName item);
    Task UpdateAsync(DayName item);
    Task DeleteAsync(int id);
    Task DeleteAsync(DayName item);
    Task<DayName?> GetByIdAsync(int id);
    Task<List<DayName>> GetAllAsync();

}
