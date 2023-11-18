using PetShower.Data;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace PetShower.Infrastructure.Repositories
{
    public class PetRepository : Repository<Pet>, IRepository<Pet>, IPetRepository
    {
        public PetRepository(DbContext context) : base(context)
        {
        }
    }
}
