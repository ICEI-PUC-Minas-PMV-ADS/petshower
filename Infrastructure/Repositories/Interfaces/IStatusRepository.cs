using PetShower.Domain.Models;

namespace PetShower.Infrastructure.Repositories.Interfaces
{
    public interface IStatusRepository
    {
        Task<Status> GetByIdAsync(long id);
        Task<List<Status>> GetAllAsync();
        Task<Status> CreateAsync(Status status);
        Task<Status> UpdateAsync(Status status);
        Task DeleteAsync(long id);
    }
}
