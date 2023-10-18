using PetShower.Domain.Models;

namespace PetShower.Infrastructure.Repositories.Interfaces
{
    public interface IAppointmentRepository
    {
        Task<Appointment> GetByIdAsync(long id);
        Task<List<Appointment>> GetAllAsync();
        Task<Appointment> CreateAsync(Appointment appointment);
        Task<Appointment> UpdateAsync(Appointment appointment);
        Task DeleteAsync(long id);
    }
}
