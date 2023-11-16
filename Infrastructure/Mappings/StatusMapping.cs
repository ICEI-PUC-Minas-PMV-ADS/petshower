using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShower.Domain.Models;

namespace PetShower.Infrastructure.Mappings
{
    public class StatusMapping : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            throw new NotImplementedException();
        }
    }
}
