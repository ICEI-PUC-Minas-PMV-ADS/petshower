using PetShower.Data;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace PetShower.Infrastructure.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AppointmentRepository(ApplicationDbContext applicationDbContext) 
        {
            _dbContext = applicationDbContext;
        }

        public async Task<List<Appointment?>> GetAllAsync()
        {
            return await _dbContext.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Veterinarian)
                .ToListAsync();
        }

        public async Task<Appointment?> GetByIdAsync(long id)
        {
            return await _dbContext.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Veterinarian)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<Appointment?> CreateAsync(Appointment appointment)
        {
            await _dbContext.Appointments.AddAsync(appointment);
            await _dbContext.SaveChangesAsync();

            return appointment;
        }

        public async Task<Appointment?> UpdateAsync(Appointment appointment)
        {
            Appointment? appointmentById = await GetByIdAsync(appointment.Id);
            appointmentById.Patient = appointment.Patient;
            appointmentById.Veterinarian = appointment.Veterinarian;
            appointmentById.Date = appointment.Date;
            appointmentById.Status = appointment.Status;
            appointment.UpdatedAt = DateTime.Now;

            _dbContext.Appointments.Update(appointmentById);
            await _dbContext.SaveChangesAsync();

            return appointmentById;
        }

        public async Task DeleteAsync(long id)
        {
            Appointment? appointmentById = await GetByIdAsync(id);
            appointmentById.IsDeleted = true;
            appointmentById.UpdatedAt = DateTime.Now;

            await UpdateAsync(appointmentById);
        }
    }
}
