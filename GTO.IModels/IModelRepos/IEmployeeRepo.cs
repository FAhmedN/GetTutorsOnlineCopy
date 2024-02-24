using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface IEmployeeRepo
{
    Task AddAsync(Employee item);
    Task UpdateAsync(Employee item);
    Task DeleteAsync(int id);
    Task DeleteAsync(Employee item);
    Task<Employee?> GetByIdAsync(int id);
    Task<List<Employee>> GetAllAsync();

}
