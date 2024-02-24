using System.ComponentModel.DataAnnotations;

namespace GTO.EntityModel.Entities
{
    public class Teacher : Employee
    {
        public ICollection<SubjectAllocation>? Schedule { get; set; }
        public ICollection<ReportHead>? AssignedReports { get; set; }

    }
}
