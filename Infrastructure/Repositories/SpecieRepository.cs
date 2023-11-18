using Microsoft.EntityFrameworkCore;
using PetShower.Data;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;

namespace PetShower.Infrastructure.Repositories
{
    public class SpecieRepository : Repository<Specie>, IRepository<Specie>, ISpecieRepository
    {
        public SpecieRepository(DbContext context) : base(context)
        {
        }
    }
}
