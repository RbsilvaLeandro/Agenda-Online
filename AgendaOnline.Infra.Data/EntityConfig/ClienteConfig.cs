using AgendaOnline.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;


namespace AgendaOnline.Infra.Data.EntityConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Clientes>
    {
        public ClienteConfig()
        {
            HasKey(c => c.IdCliente);
            Property(c => c.RazaoSocial).IsRequired().HasMaxLength(100);
            Property(c => c.Telefone).IsRequired().HasMaxLength(20);
            Property(c => c.Celular).HasMaxLength(20);
            Property(c => c.Contato).HasMaxLength(40);
            Property(c => c.Email).HasMaxLength(70);
            Property(c => c.WebSite).HasMaxLength(100);
        }
    }
}
