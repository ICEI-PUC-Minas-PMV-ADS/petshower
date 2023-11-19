using PetShower.Domain.Models;

namespace PetShower.Infrastructure.Repositories.Interfaces
{
    public interface IPetRepository
    {
        Task<IEnumerable<Pet>> GetPetsByUserIdAsync(string userId);
    }
}
