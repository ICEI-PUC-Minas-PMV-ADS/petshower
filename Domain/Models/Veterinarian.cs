namespace PetShower.Domain.Models
{
    public class Veterinarian : EntityBase
    {
        public virtual required string Name { get; set; }
        public virtual required long GenderId { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual int? Age { get; set; }
    }
}
