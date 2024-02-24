using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface ITeacherRepo
{
    Task AddAsync(Teacher item);
    Task UpdateAsync(Teacher item);
    Task DeleteAsync(int id);
    Task DeleteAsync(Teacher item);
    Task<Teacher?> GetByIdAsync(int id);
    Task<List<Teacher>> GetAllAsync();

}
