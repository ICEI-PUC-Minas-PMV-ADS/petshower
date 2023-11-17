using PetShower.Domain.Models;

namespace PetShower.Infrastructure.Repositories.Interfaces
{
    public interface IPetRepository
    {
        Task<List<Pet?>> GetAllAsync();
        Task<Pet?> GetByIdAsync(long id);
        Task<Pet?> CreateAsync(Pet pet);
        Task<Pet?> UpdateAsync(Pet pet);
        Task DeleteAsync(long id);
    }
}
