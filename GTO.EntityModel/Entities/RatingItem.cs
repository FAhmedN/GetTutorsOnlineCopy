using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTO.EntityModel.Entities
{
    [Table("Ratings")]
    public class RatingItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Value {  get; set; }

        [Required, StringLength(3)]
        [Display(Name = "Short SubName")]
        public string ShortName { get; set; } = string.Empty;

        [Required]
        [StringLength(400)]
        [Display(Name = "Remarks")]
        public string Description { get; set; } = string.Empty;


    }
}
