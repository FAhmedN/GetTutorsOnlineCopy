using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface IStudentRepo
{
    Task AddAsync(Student item);
    Task UpdateAsync(Student item);
    Task DeleteAsync(int id);
    Task DeleteAsync(Student item);
    Task<Student?> GetByIdAsync(int id);
    Task<List<ReportItem>> GetAllAsync();

}
