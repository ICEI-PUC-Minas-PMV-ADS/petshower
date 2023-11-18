using PetShower.Domain.Models;

namespace PetShower.Infrastructure.Repositories.Interfaces
{
    public interface IVeterinarianRepository
    {
        Task<List<Veterinarian?>> GetAllAsync();
        Task<Veterinarian?> GetByIdAsync(long id);
        Task<Veterinarian?> CreateAsync(Veterinarian veterinarian);
        Task<Veterinarian?> UpdateAsync(Veterinarian veterinarian);
        Task DeleteAsync(long id);
    }
}
