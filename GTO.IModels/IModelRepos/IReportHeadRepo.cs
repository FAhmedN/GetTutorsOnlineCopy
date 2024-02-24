using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface IReportHeadRepo
{
    Task AddAsync(ReportHead item);
    Task UpdateAsync(ReportHead item);
    Task DeleteAsync(int id);
    Task DeleteAsync(ReportHead item);
    Task<ReportHead?> GetByIdAsync(int id);
    Task<List<ReportHead>> GetAllAsync();

}
