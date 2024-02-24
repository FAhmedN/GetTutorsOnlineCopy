using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTO.EntityModel.Entities
{
    [Table("SubAlloc")]
    public class SubjectAllocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public virtual Student Student { get; set; } = new();

        [Required]
        public virtual Teacher Teacher { get; set; } = new();

        [Required]
        public virtual SubjectName Subject { get; set; } = new();

        [Required]
        [Display(Name = "Allocated Day")]
        public virtual DayName Day { get; set; } = new();

        [Display(Name = "Session Time")]
        public DateTime? SessionTime { get; set; }

        /// <summary>
        /// Gets or set the date when this schedule become active,
        /// or teacher starts to take the classes of this subject for this student
        /// </summary>
        /// 
        [Required]
        [Display(Name = "Starting Date")]
        public DateTime StartDate {  get; set; }

        /// <summary>
        /// Gets or set the date when this schedule ends,
        /// or teacher has stopped taking the classes of this subject for this student
        /// </summary>
        /// 
        [Display(Name = "Ending Date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or set whether this schedule is active or not
        /// </summary>
        /// 
        public bool IsActive { get; set; } = true;

        public void DeactivateSchedule()
        {
            throw new NotImplementedException();
        }

    }
}
