using PetShower.Domain.Models;

namespace PetShower.Application.Services.Interfaces
{
    public interface IAppointmentService
    {
        Task<List<Appointment>> GetAllAppointments();
        Task<Appointment> GetAppointmentById(long id);
        Task<Appointment> CreateAppointment(Appointment appointment);
        Task<Appointment> UpdateAppointment(Appointment appointment);
        Task SoftDeleteAppointment(long id);
        Task<IEnumerable<Appointment>> GetAppointmentsByPetIdAsync(long userId);
    }
}
