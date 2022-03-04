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
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoneDigito>()
                .HasKey(c => new { c.UF, c.DDD, c.DIGITO });
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
        public DbSet<ClientesMarcas> ClientesMarcas { get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<ConfigMail> ConfigMail { get; set; }
        public DbSet<ConfigMailOperador> ConfigMailOperador { get; set; }
        public DbSet<Consultas> Consultas { get; set; }
        public DbSet<Contatos> Contatos { get; set; }
        public DbSet<DDDsDiferentes> DDDsDiferentes { get; set; }
        public DbSet<DDDOperadores> DDDOperadores { get; set; }
        public DbSet<EstadosOperadores> EstadosOperadores { get; set; }
        public DbSet<Excecoes> Excecoes { get; set; }
        public DbSet<ExcecoesCidade> ExcecoesCidade { get; set; }
        public DbSet<ExcecoesEstado> ExcecoesEstado { get; set; }
        public DbSet<ExcecoesSegmentos> ExcecoesSegmentos { get; set; }
        public DbSet<FaseContato> FaseContato { get; set; }
        public DbSet<Feriados> Feriados { get; set; }
        public DbSet<Fidelizacoes> Fidelizacoes { get; set; }
        public DbSet<FonesCampanhaCli> FonesCampanhaCli { get; set; }
        public DbSet<FoneAreas> FoneAreas { get; set; }
        public DbSet<FoneDigito> FoneDigito { get; set; }
        public DbSet<Grupos> Grupos { get; set; }
        public DbSet<GruposXOperadores> GruposXOperadores { get; set; }
    }
}