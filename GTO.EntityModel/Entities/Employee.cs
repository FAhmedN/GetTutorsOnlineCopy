using System.ComponentModel.DataAnnotations;

namespace GTO.EntityModel.Entities
{
    public class Employee : Personnel
    {
        //[Required]
        //public virtual Designation? Designation { get; set; }

        [Required]
        public DateTime EmployementDate { get; set; }

        [Required]
        public string EmployeeNumber { get; set; } = string.Empty;

        public string Qualification { get; set; } = string.Empty;

        public string SkypeId { get; set; } = string.Empty;

        public string SkypeName { get; set; } = string.Empty;

        [DataType(DataType.EmailAddress)]
        public string OfficialEmail { get; set; } = string.Empty;

        [DataType(DataType.EmailAddress)]
        public string GoogleId { get; set; } = string.Empty;

    }
}
