using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShower.Domain.Models;

namespace PetShower.Infrastructure.Mappings
{
    public class GenderMapping : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            throw new NotImplementedException();
        }
    }
}
