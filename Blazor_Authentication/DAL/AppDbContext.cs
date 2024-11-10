using Blazor_Authentication.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Authentication.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }

    public DbSet<CuentaUsuario> CuentaUsuario { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CuentaUsuario>().HasData(new List<CuentaUsuario>()
    {
        new CuentaUsuario(){Id = 1, NombreUsuario = "Frailyn", Contraseña = "1234", Rol  = "Administrator"},
        new CuentaUsuario(){Id = 2, NombreUsuario = "Abel", Contraseña = "12344", Rol  = "User"},
    });
        base.OnModelCreating(modelBuilder);
    }
}
