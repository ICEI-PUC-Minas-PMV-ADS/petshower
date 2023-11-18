using Microsoft.EntityFrameworkCore;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;

namespace PetShower.Infrastructure.Repositories
{
    public class VeterinarianRepository : Repository<Veterinarian>, IRepository<Veterinarian>, IVeterinarianRepository
    {
        public VeterinarianRepository(DbContext context) : base(context)
        {
        }
    }
}
