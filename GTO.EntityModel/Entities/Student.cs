using System.ComponentModel.DataAnnotations;

namespace GTO.EntityModel.Entities
{
    public class Student : Personnel
    {
        public virtual ELevel Class { get; set; } = new();

        [Required]
        public string SkypId { get; set; } = string.Empty;

        public string SkypName { get; set; } = string.Empty;

        public string SchoolName { get; set; } = string.Empty;

        public virtual Region Region { get; set; } = new();

        public virtual Parent Parent { get; set; } = new();

    }
}
