using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTO.EntityModel.Entities
{
    [Table("WeekDays")]
    //[Index(nameof(SubName), IsUnique = true)]
    public class DayName
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Day SubName")]
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<SubjectAllocation>? DaySchedule { get; set; }


    }
}
