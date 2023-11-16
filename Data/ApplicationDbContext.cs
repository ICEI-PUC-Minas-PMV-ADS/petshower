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
    public DbSet<Breed> Breeds { get; set; }
    public DbSet<Status> Statuss { get; set; }
    public DbSet<Gender> Genders { get; set; }
    public DbSet<Specie> Species { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new PetMapping());
        builder.ApplyConfiguration(new AppointmentMapping());
        builder.ApplyConfiguration(new BreedMapping());
        builder.ApplyConfiguration(new StatusMapping());
        builder.ApplyConfiguration(new GenderMapping());
        builder.ApplyConfiguration(new SpecieMapping());

        base.OnModelCreating(builder);
    }
}
