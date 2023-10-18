using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Mappings;

namespace PetShower.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Pet> Pets { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new PetMapping());
        builder.ApplyConfiguration(new AppointmentMapping());

        base.OnModelCreating(builder);
    }
}
