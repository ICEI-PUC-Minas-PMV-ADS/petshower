namespace PetShower.Domain.Models
{
    public class Specie : EntityBase
    {
        public virtual required string Name { get; set; }
        public virtual required string Description { get; set; }
    }
}
