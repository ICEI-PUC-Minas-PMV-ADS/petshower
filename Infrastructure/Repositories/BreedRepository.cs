using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;

namespace PetShower.Infrastructure.Repositories
{
    public class BreedRepository : IBreedRepository
    {
        public Task<Breed> CreateAsync(Breed breed)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Breed>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Breed> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Breed> UpdateAsync(Breed breed)
        {
            throw new NotImplementedException();
        }
    }
}
