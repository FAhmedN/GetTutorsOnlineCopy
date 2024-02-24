using GTO.EntityModel.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTO.EntityModel.Entities
{
    [Table("Months")]
    public class AssessmentMonth
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Month Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Month SubName")]
        [EnumDataType(typeof(MonthNamesEnum), ErrorMessage = "Please choose a valid month name")]
        public MonthNamesEnum MonthName {  get; set; }

        [Required]
        [StringLength(4)]
        public string Year { get; set; } = string.Empty;

        [Required]
        public DateTime SubmitDeadline { get; set; }

        [NotMapped]
        public string Month => MonthName.ToString() + " - " + Year.ToString();

        public virtual ICollection<Assessment>? Assessments { get; set; }

    }
}
