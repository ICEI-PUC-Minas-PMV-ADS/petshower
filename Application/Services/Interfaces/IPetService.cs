using PetShower.Domain.Models;

namespace PetShower.Application.Services.Interfaces
{
    public interface IPetService
    {
        Task<List<Pet>> GetAllPets();
        Task<Pet> GetPetById(long id);
        Task<Pet> CreatePet(Pet pet);
        Task<Pet> UpdatePet(Pet pet);
        Task SoftDeletePet(long id);
        Task<IEnumerable<Pet>> GetPetsByUserIdAsync(string userId);
    }

}
