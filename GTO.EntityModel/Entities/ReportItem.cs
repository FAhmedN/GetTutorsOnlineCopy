using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTO.EntityModel.Entities
{
    [Table("RptDetails")]
    public class ReportItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        public virtual ReportHead Head { get; set; } = new();

        [Required]
        public virtual Assessment Assessment { get; set; } = new();

        public string? Grade {  get; set; }
    }
}
