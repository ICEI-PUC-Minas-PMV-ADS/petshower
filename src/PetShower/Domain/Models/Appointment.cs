using Microsoft.AspNetCore.Identity;
using PetShower.Domain.Enums;

namespace PetShower.Domain.Models
{
    public class Appointment : EntityBase
    {
        public Pet Patient { get; set; }
        public IdentityUser Veterinarian { get; set; }
        public DateTime Date { get; set; }
        public StatusEnum Status { get; set; }
    }
}
