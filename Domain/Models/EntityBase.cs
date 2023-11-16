using Microsoft.AspNetCore.Identity;

namespace PetShower.Domain.Models
{
    public class EntityBase
    {
        public virtual required long Id { get; set; }
        public virtual required DateTime CreatedAt { get; set; }
        public virtual required DateTime UpdatedAt { get; set; }
        public virtual required bool IsDeleted { get; set; }
    }
}
