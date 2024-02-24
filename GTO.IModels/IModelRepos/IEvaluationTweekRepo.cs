using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface IEvaluationTweekRepo
{
    Task AddAsync(EvaluationTweak item);
    Task UpdateAsync(EvaluationTweak item);
    Task DeleteAsync(int id);
    Task DeleteAsync(EvaluationTweak item);
    Task<EvaluationTweak?> GetByIdAsync(int id);
    Task<List<EvaluationTweak>> GetAllAsync();

}
