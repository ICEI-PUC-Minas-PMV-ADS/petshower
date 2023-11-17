using PetShower.Data;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;

namespace PetShower.Infrastructure.Repositories
{
    public class SpecieRepository : ISpecieRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public SpecieRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public Task<List<Specie?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Specie?> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Specie?> CreateAsync(Specie specie)
        {
            throw new NotImplementedException();
        }
        public Task<Specie?> UpdateAsync(Specie specie)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
