namespace GTO.EntityModel.Entities
{
    public class ELevel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } =  string.Empty;

        public virtual Region Region { get; set; } = new();

        public virtual ICollection<Student>? Students { get; set; }


    }
}
