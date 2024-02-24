using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTO.EntityModel.Entities
{
    public class Personnel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get; set;
        }

        [Required, StringLength(50), Display(Name = "Full SubName")] 
        public string Name { get; set; } = string.Empty; 
        
        [Display(Name = "Date of Birth")] 
        public DateTime? DOB { get; set; } = DateTime.Now; 
        
        [Required]
        [StringLength(20)]
        [Display(Name = "Contact Number")] 
        public string ContactNumber { get; set; } = string.Empty;
        
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")] 
        public string EmailAddress { get; set; } = string.Empty;
        
        [NotMapped]
        public string Age
        {
            get => GetAge();
        }
        string GetAge()
        {
            DateTime currentDate = DateTime.Now;
            if (!DOB.HasValue)
            {
                DOB = DateTime.Now;
            }
            int years = currentDate.Year - DOB.Value.Year;
            int months = currentDate.Month - DOB.Value.Month;
            int days = currentDate.Day - DOB.Value.Day;
            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(currentDate.Year, currentDate.Month - 1);
            }
            if (months < 0)
            {
                years--;
                months += 12;
            }
            return $"{years} years, {months} months, {days} days";
        }
    }
}
