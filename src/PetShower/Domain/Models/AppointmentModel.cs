using PetShower.Domain.Enums;

namespace PetShower.Domain.Models
{
    public class AppointmentModel : EntityBase
    {
        public PetModel Patient { get; set; }
        public VeterinarianModel Veterinarian { get; set; }
        public DateTime Date { get; set; }
        public StatusEnum Status { get; set; }
    }
}
