using PetShower.Data;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace PetShower.Infrastructure.Repositories
{
    public class PetRepository : Repository<Pet>, IRepository<Pet>, IPetRepository
    {
        private readonly DbContext _context;

        public PetRepository(DbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pet>> GetPetsByUserIdAsync(string userId)
        {
            return await _context.Set<Pet>()
                .Where(p => p.OwnerId == userId)
                .ToListAsync();
        }
    }
}
