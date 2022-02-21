using Microsoft.EntityFrameworkCore;
using Inpulse.Domain;

namespace Inpulse.WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
             
        }

        public DbSet<Usuarios> Usuarios { get; set; }        
        public DbSet<Operadores> Operadores { get; set; }
        public DbSet<Acoes> Acoes { get; set; }
        public DbSet<Campanhas> Campanhas { get; set; }
        public DbSet<CampanhasXOperadores> CampanhasXOperadores { get; set; }
        public DbSet<CampanhasClientes> CampanhasClientes { get; set; }
        public DbSet<CampanhaClientesCor> CampanhaClientesCors { get; set; }
        public DbSet<Cargos> Cargos { get; set; }
        public DbSet<ChamadasPerdidas> ChamadasPerdidas { get; set; }
        public DbSet<ChamadasReceptivo> ChamadasReceptivo { get; set; }
        public DbSet<Cidades> Cidades { get; set; }
        public DbSet<CidadesDDD> CidadesDDD { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<ClientesBase> ClientesBase { get; set; }
    }
}