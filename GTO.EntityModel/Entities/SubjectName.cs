using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTO.EntityModel.Entities
{
    [Table("Subjects")]
    //[Index(nameof(SubName), IsUnique = true)]
    public class SubjectName
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {  get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Subject Name")]
        public string? SubName { get; set; }

        public virtual ICollection<EvaluationTweak>? EvaluationTweaks { get; set; }
    }
}
