using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTO.EntityModel.Entities
{
    [Table("RptHead")]
    public class ReportHead
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public virtual Student Student { get; set; } = new();

        [Required]
        [Display(Name = "Report Month")]
        public virtual AssessmentMonth Month { get; set; } = new();

        public virtual ICollection<ReportItem>? Items { get; set; }

        [Required]
        [Display(Name = "Assigned To")]
        public virtual Teacher AssignedToTeacher { get; set; }

        [Required]
        [Display(Name = "Assigned Date")]
        public DateTime AssignedDate { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Assigned By")]
        public virtual Coordinator AssugnedBy { get; set; } = new();





    }
}
