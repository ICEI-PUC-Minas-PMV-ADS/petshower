using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;

namespace PetShower.Infrastructure.Repositories
{
    public class VeterinarianRepository : IVeterinarianRepository
    {
        public Task<List<Veterinarian?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Veterinarian?> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Veterinarian?> CreateAsync(Veterinarian veterinarian)
        {
            throw new NotImplementedException();
        }

        public Task<Veterinarian?> UpdateAsync(Veterinarian veterinarian)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
