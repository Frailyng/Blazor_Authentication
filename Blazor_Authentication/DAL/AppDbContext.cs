using Blazor_Authentication.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Authentication.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }

    public DbSet<CuentaUsuario> CuentaUsuario { get; set; }
}
