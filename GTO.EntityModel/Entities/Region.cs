namespace GTO.EntityModel.Entities
{
    public class Region
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<ELevel>? Classes { get; set; }

        public virtual ICollection<Student>? Students { get; set; }


    }
}
