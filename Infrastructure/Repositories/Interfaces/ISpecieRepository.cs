using PetShower.Domain.Models;

namespace PetShower.Infrastructure.Repositories.Interfaces
{
    public interface ISpecieRepository
    {
        Task<List<Specie?>> GetAllAsync();
        Task<Specie?> GetByIdAsync(long id);
        Task<Specie?> CreateAsync(Specie specie);
        Task<Specie?> UpdateAsync(Specie specie);
        Task DeleteAsync(long id);
    }
}
