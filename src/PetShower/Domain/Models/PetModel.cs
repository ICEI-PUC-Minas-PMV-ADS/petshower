using PetShower.Domain.Enums;

namespace PetShower.Domain.Models
{
    public class PetModel : EntityBase
    {
        public string Name { get; set; }
        public SpeciesEnum Specie { get; set; }
        public BreedEnum Breed { get; set; }
        public Owner Owner { get; set; }
        public Gender Gender { get; set; }
    }
}
