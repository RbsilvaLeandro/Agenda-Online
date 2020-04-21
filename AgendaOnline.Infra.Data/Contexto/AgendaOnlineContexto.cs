using AgendaOnline.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using AgendaOnline.Dominio.Entidades;


namespace AgendaOnline.Infra.Data.Contexto
{
    public class AgendaOnlineContexto : DbContext
    {
        public AgendaOnlineContexto()
            :base("AgendaOnline")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Enderecos> Enderecos { get; set; }
        public DbSet<Historico> Historico { get; set; }
        public DbSet<Lembretes> Lembretes { get; set; }
        public DbSet<LogUsuario> LogUsuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == "Id" + p.ReflectedType.Name).Configure(p => p.IsKey());
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new HistoricoConfig());
            modelBuilder.Configurations.Add(new LembreteConfig());
            modelBuilder.Configurations.Add(new LogUsuarioConfig());
        }
    }
}
