namespace GTO.EntityModel.Entities
{
    public class Parent : Personnel
    {

        public virtual ICollection<Student>? Children { get; set; }
    }
}
