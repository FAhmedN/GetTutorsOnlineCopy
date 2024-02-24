using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface IParentRepo
{
    Task AddAsync(Parent item);
    Task UpdateAsync(Parent item);
    Task DeleteAsync(int id);
    Task DeleteAsync(Parent item);
    Task<EvaluationTweak?> GetByIdAsync(int id);
    Task<List<Parent>> GetAllAsync();

}
