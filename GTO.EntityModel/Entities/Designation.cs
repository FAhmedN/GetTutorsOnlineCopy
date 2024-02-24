using System.ComponentModel.DataAnnotations;

namespace GTO.EntityModel.Entities
{
    public class Designation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Designattion SubName")]
        public string Name { get; set; } = string.Empty;
    }
}
