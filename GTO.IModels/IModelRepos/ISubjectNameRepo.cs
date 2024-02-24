using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface ISubjectNameRepo
{
    Task AddAsync(SubjectName item);
    Task UpdateAsync(SubjectName item);
    Task DeleteAsync(int id);
    Task DeleteAsync(SubjectName item);
    Task<SubjectName?> GetByIdAsync(int id);
    Task<List<SubjectName>> GetAllAsync();

}
