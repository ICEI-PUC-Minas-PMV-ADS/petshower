using PetShower.Application.Services.Interfaces;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;

namespace PetShower.Application.Services
{
    public class VeterinarianService : IVeterinarianService
    {
        private readonly IRepository<Veterinarian> _veterinarianRepository;

        public VeterinarianService(IRepository<Veterinarian> veterinarianRepository)
        {
            _veterinarianRepository = veterinarianRepository;
        }

        public async Task<List<Veterinarian>> GetAllVeterinarians()
        {
            return await _veterinarianRepository.GetAllAsync();
        }

        public async Task<Veterinarian> GetVeterinarianById(long id)
        {
            return await _veterinarianRepository.GetByIdAsync(id);
        }

        public async Task<Veterinarian> CreateVeterinarian(Veterinarian veterinarian)
        {
            return await _veterinarianRepository.CreateAsync(veterinarian);
        }

        public async Task<Veterinarian> UpdateVeterinarian(Veterinarian veterinarian)
        {
            return await _veterinarianRepository.UpdateAsync(veterinarian);
        }

        public async Task SoftDeleteVeterinarian(long id)
        {
            await _veterinarianRepository.DeleteAsync(id);
        }
    }

}
