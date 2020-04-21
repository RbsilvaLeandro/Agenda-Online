using AgendaOnline.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace AgendaOnline.Infra.Data.EntityConfig
{
    public class LembreteConfig : EntityTypeConfiguration<Lembretes>
    {
        public LembreteConfig()
        {
            HasKey(l => l.IdLembrete);
            Property(l => l.Lembrete).HasMaxLength(200);
            HasRequired(l => l.Clientes).WithMany().HasForeignKey(l => l.ClienteId);
        }
    }
}
