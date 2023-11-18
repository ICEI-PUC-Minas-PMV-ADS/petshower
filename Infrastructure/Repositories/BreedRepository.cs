using Microsoft.EntityFrameworkCore;
using PetShower.Data;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;

namespace PetShower.Infrastructure.Repositories
{
    public class BreedRepository : Repository<Breed>, IRepository<Breed>, IBreedRepository
    {
        public BreedRepository(DbContext context) : base(context)
        {
        }
    }
}
