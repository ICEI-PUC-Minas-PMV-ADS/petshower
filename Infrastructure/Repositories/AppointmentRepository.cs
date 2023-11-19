using PetShower.Data;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace PetShower.Infrastructure.Repositories
{
    public class AppointmentRepository : Repository<Appointment>, IRepository<Appointment>, IAppointmentRepository
    {
        private readonly DbContext _context;

        public AppointmentRepository(DbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentsByPetIdAsync(long petId)
        {
            return await _context.Set<Appointment>()
                .Where(a => a.PatientId == petId)
                .ToListAsync();
        }
    }

}