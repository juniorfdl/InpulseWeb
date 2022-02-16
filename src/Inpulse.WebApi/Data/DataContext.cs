using Microsoft.EntityFrameworkCore;
using Inpulse.Autentication.Domain;

namespace Inpulse.WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
             
        }

        public DbSet<Usuarios> Usuarios { get; set; }        
        public DbSet<Tenants> Tenants { get; set; }
    }
}