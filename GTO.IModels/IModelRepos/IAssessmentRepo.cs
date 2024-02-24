using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface IAssessmentRepo
{
    Task AddAsync(Assessment item);
    Task UpdateAsync(Assessment item);
    Task DeleteAsync(int id);
    Task DeleteAsync(Assessment item);
    Task<Assessment?> GetByIdAsync(int id);
    Task<List<Assessment>> GetAllAsync();
    Task<List<Assessment?>> GetAllAsync(Teacher conductedBy);
    Task<List<Assessment?>> GetAllAsync(Student student);
}
