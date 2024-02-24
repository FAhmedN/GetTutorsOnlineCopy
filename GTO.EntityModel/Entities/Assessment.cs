using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTO.EntityModel.Entities
{
    public class Assessment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Assessments Id")]
        public int Id { get; set; }

        [Required]
        public virtual Student Student { get; set; } = new();

        [Required]
        [Display(Name = "Conducted By")]
        public virtual Teacher ConductedBy { get; set; } = new();

        [Required]
        public virtual SubjectName Subject { get; set; } = new();

        //[Required]
        //public virtual Month Month { get; set; }

        [Display(Name = "Assessments Date")]
        public DateTime? ConductDate { get; set; }

        public bool? Assigned {  get; set; }

        public bool? Conducted { get; set; }

        public bool? Marked { get; set; }

        public bool? ReportGenerated { get; set; }

        [Display(Name = "Board Link")]
        public string? BoardLink { get; set; }

        public int MaxMarks { get; set; } = 1;

        public int ObtainedMarks { get; set; } = 0;

        [NotMapped]
        public decimal Percentage { get => ObtainedMarks / MaxMarks * 100; }
    }
}
