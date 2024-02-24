using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface IAssessmentMonthRepo
{
    Task AddAsync(AssessmentMonth item);
    Task UpdateAsync(AssessmentMonth item);
    Task DeleteAsync(int id);
    Task DeleteAsync(AssessmentMonth item);
    Task<AssessmentMonth?> GetByIdAsync(int id);
    Task<List<AssessmentMonth>> GetAllAsync();
}
