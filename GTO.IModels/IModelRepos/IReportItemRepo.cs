using GTO.EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.IModels.IModelRepos;

public interface IReportItemRepo
{
    Task AddAsync(ReportItem item);
    Task UpdateAsync(ReportItem item);
    Task DeleteAsync(int id);
    Task DeleteAsync(ReportItem item);
    Task<ReportItem?> GetByIdAsync(int id);
    Task<List<ReportItem>> GetAllAsync();

}
