using Microsoft.AspNetCore.Identity;
using PetShower.Domain.Enums;

namespace PetShower.Domain.Models
{
    public class Pet : EntityBase
    {
        public string Name { get; set; }
        public SpeciesEnum Specie { get; set; }
        public BreedEnum Breed { get; set; }
        public IdentityUser Owner { get; set; }
        public GenderEnum Gender { get; set; }
    }
}
