using Microsoft.EntityFrameworkCore;
using PetShower.Data;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;

namespace PetShower.Infrastructure.Repositories
{
    public class GenderRepository : Repository<Gender>, IRepository<Gender>, IGenderRepository
    {
        public GenderRepository(DbContext context) : base(context)
        {
        }
    }
}
