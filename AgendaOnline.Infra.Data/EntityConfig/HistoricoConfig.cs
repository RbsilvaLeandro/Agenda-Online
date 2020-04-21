using AgendaOnline.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace AgendaOnline.Infra.Data.EntityConfig
{
    public class HistoricoConfig : EntityTypeConfiguration<Historico>
    {
        public HistoricoConfig()
        {
            HasKey(h => h.IdHistorico);
            Property(h => h.HistoricoDescricao).HasMaxLength(500);
            Property(h => h.Obs).HasMaxLength(500);
            HasRequired(h => h.Clientes).WithMany().HasForeignKey(h => h.ClienteId);

        }
    }
}
