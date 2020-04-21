using AgendaOnline.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;


namespace AgendaOnline.Infra.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Enderecos>
    {
        public EnderecoConfig()
        {
            HasKey(e => e.IdEndereco);
            Property(e => e.Endereco).IsRequired().HasMaxLength(100);
            Property(e => e.Numero).IsRequired();
            Property(e => e.Cidade).IsRequired().HasMaxLength(60);
            HasRequired(e => e.Clientes).WithMany().HasForeignKey(e => e.ClienteId);
        }
    }
}
