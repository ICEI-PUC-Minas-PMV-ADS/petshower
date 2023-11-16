namespace PetShower.Domain.Models
{
    public class Breed : EntityBase
    {
        public virtual required string Name { get; set; }
        public virtual string? Description { get; set; }
    }
}
