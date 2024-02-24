using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTO.EntityModel.Entities
{
    [Table("Evaluations")]
    public class SubjectEvaluation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public virtual Assessment Assessment { get; set; } = new();

        [Required, StringLength(400)]
        [Display(Name = "Topic SubName")]
        public string TopicName {  get; set; } = string.Empty;

        [Required]
        public virtual RatingItem Rating { get; set; } = new();

        public string? Remarks { get; set; }
    
    }
}
