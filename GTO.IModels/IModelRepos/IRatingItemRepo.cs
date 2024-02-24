using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface IRatingItemRepo
{
    Task AddAsync(RatingItem item);
    Task UpdateAsync(RatingItem item);
    Task DeleteAsync(int id);
    Task DeleteAsync(RatingItem item);
    Task<RatingItem?> GetByIdAsync(int id);
    Task<List<RatingItem>> GetAllAsync();

}
