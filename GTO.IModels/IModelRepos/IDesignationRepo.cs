using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface IDesignationRepo
{
    Task AddAsync(Designation item);
    Task UpdateAsync(Designation item);
    Task DeleteAsync(int id);
    Task DeleteAsync(Designation item);
    Task<Designation?> GetByIdAsync(int id);
    Task<List<Designation>> GetAllAsync();

}
