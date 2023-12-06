using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Authen.Data.Domain;
namespace Authen.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{

     public DbSet<TosadorBanhista> TosadorBanhista { get; set; }
     public DbSet<Agenda> Agenda { get; set; }
     public DbSet<HorarioAgenda> HorarioAgenda { get; set; }

     public DbSet<Pet> Pet { get; set; }
       public DbSet<Agendamento> Agendamento { get; set; }
}
