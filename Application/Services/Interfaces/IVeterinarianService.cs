using PetShower.Domain.Models;

namespace PetShower.Application.Services.Interfaces
{
    public interface IVeterinarianService
    {
        Task<List<Veterinarian>> GetAllVeterinarians();
        Task<Veterinarian> GetVeterinarianById(long id);
        Task<Veterinarian> CreateVeterinarian(Veterinarian veterinarian);
        Task<Veterinarian> UpdateVeterinarian(Veterinarian veterinarian);
        Task SoftDeleteVeterinarian(long id);
    }
}
