using Microsoft.AspNetCore.Identity;

namespace PetShower.Domain.Models
{
    public class Pet : EntityBase
    {
        public virtual required string Name { get; set; }
        public virtual required string SpecieId { get; set; }
        public virtual required Specie Specie { get; set; }
        public virtual required long BreedId { get; set; }
        public virtual required Breed Breed { get; set; }
        public virtual required long OwnerId { get; set; }
        public virtual required IdentityUser Owner { get; set; }
        public virtual required long GenderId { get; set; }
        public virtual required Gender Gender { get; set; }
    }
}
