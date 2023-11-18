using Microsoft.AspNetCore.Identity;

namespace PetShower.Domain.Models
{
    public class Pet : EntityBase
    {
        public virtual required string Name { get; set; }
        public virtual required long SpecieId { get; set; }
        public virtual Specie? Specie { get; set; }
        public virtual required long BreedId { get; set; }
        public virtual Breed? Breed { get; set; }
        public virtual required string OwnerId { get; set; }
        public virtual IdentityUser? Owner { get; set; }
        public virtual required long GenderId { get; set; }
        public virtual Gender? Gender { get; set; }
    }
}
