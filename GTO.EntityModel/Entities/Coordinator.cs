using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.EntityModel.Entities;

public class Coordinator : Employee
{
    public virtual ICollection<ReportHead>? AssignedReports { get; set; }

}
