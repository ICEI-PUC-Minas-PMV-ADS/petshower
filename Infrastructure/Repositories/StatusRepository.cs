using PetShower.Data;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;

namespace PetShower.Infrastructure.Repositories
{
    public class StatusRepository : IStatusRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public StatusRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public Task<List<Status?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Status?> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Status?> CreateAsync(Status status)
        {
            throw new NotImplementedException();
        }

        public Task<Status?> UpdateAsync(Status status)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
