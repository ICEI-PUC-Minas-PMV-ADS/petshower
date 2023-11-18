using PetShower.Data;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace PetShower.Infrastructure.Repositories
{
    public class AppointmentRepository : Repository<Appointment>, IRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(DbContext context) : base(context)
        {
        }
    }
}