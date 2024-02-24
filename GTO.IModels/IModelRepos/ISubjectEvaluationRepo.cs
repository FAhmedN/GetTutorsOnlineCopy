using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface ISubjectEvaluationRepo
{
    Task AddAsync(SubjectEvaluation item);
    Task UpdateAsync(SubjectEvaluation item);
    Task DeleteAsync(int id);
    Task DeleteAsync(SubjectEvaluation item);
    Task<SubjectEvaluation?> GetByIdAsync(int id);
    Task<List<SubjectEvaluation>> GetAllAsync();

}
