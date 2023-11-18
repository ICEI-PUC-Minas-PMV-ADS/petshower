using Microsoft.EntityFrameworkCore;
using PetShower.Data;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;

namespace PetShower.Infrastructure.Repositories
{
    public class StatusRepository : Repository<Status>, IRepository<Status>, IStatusRepository
    {
        public StatusRepository(DbContext context) : base(context)
        {
        }
    }
}
