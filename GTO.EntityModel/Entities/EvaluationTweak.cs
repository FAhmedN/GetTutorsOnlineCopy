using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTO.EntityModel.Entities
{
    [Table("Tweaks")]
    public class EvaluationTweak
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {  get; set; }

        [Required]
        public virtual SubjectName Subject { get; set; } = new();

        [Required]
        [Display(Name = "Tweak SubName")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Tweak Description")]
        public string Tweak { get; set; } = string.Empty;

    }
}
