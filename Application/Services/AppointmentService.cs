using PetShower.Application.Services.Interfaces;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;

namespace PetShower.Application.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IRepository<Appointment> _appointmentRepository;
        private readonly IAppointmentRepository _appointmentRepository1;

        public AppointmentService(IRepository<Appointment> appointmentRepository, IAppointmentRepository appointmentRepository1)
        {
            _appointmentRepository = appointmentRepository;
            _appointmentRepository1 = appointmentRepository1;
        }

        public async Task<List<Appointment>> GetAllAppointments()
        {
            return await _appointmentRepository.GetAllAsync();
        }

        public async Task<Appointment> GetAppointmentById(long id)
        {
            return await _appointmentRepository.GetByIdAsync(id);
        }

        public async Task<Appointment> CreateAppointment(Appointment appointment)
        {
            return await _appointmentRepository.CreateAsync(appointment);
        }

        public async Task<Appointment> UpdateAppointment(Appointment appointment)
        {
            return await _appointmentRepository.UpdateAsync(appointment);
        }

        public async Task SoftDeleteAppointment(long id)
        {
            await _appointmentRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentsByPetIdAsync(long userId)
        {
            return await _appointmentRepository1.GetAppointmentsByPetIdAsync(userId);
        }
    }

}
