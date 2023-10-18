using Microsoft.AspNetCore.Identity;

namespace PetShower.Domain.Models
{
    public class EntityBase
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
