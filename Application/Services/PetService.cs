using PetShower.Application.Services.Interfaces;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;

namespace PetShower.Application.Services
{
    public class PetService : IPetService
    {
        private readonly IRepository<Pet> _petRepository;

        public PetService(IRepository<Pet> petRepository)
        {
            _petRepository = petRepository;
        }

        public async Task<List<Pet>> GetAllPets()
        {
            return await _petRepository.GetAllAsync();
        }

        public async Task<Pet> GetPetById(long id)
        {
            return await _petRepository.GetByIdAsync(id);
        }

        public async Task<Pet> CreatePet(Pet pet)
        {
            return await _petRepository.CreateAsync(pet);
        }

        public async Task<Pet> UpdatePet(Pet pet)
        {
            return await _petRepository.UpdateAsync(pet);
        }

        public async Task SoftDeletePet(long id)
        {
            await _petRepository.DeleteAsync(id);
        }
    }
}
