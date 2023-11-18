using Microsoft.AspNetCore.Identity;

namespace PetShower.Domain.Models
{
    public class Appointment : EntityBase
    {
        public virtual required long PatientId { get; set; }
        public virtual required Pet Patient { get; set; }
        public virtual required long VeterinarianId { get; set; }
        public virtual required Veterinarian Veterinarian { get; set; }
        public virtual string? Service {  get; set; }
        public virtual required DateTime Date { get; set; }
        public virtual required long StatusId { get; set; }
        public virtual required Status Status { get; set; }
    }
}
