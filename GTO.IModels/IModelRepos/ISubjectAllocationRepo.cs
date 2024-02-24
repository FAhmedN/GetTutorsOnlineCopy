using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface ISubjectAllocationRepo
{
    Task AddAsync(SubjectAllocation item);
    Task UpdateAsync(SubjectAllocation item);
    Task DeleteAsync(int id);
    Task DeleteAsync(SubjectAllocation item);
    Task<SubjectAllocation?> GetByIdAsync(int id);
    Task<List<SubjectAllocation>> GetAllAsync();

}
