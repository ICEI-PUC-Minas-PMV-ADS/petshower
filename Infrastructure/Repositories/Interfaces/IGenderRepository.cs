using PetShower.Domain.Models;

namespace PetShower.Infrastructure.Repositories.Interfaces
{
    public interface IGenderRepository
    {
        Task<List<Gender?>> GetAllAsync();
        Task<Gender?> GetByIdAsync(long id);
        Task<Gender?> CreateAsync(Gender gender);
        Task<Gender?> UpdateAsync(Gender gender);
        Task DeleteAsync(long id);
    }
}
