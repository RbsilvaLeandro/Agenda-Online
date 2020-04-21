using AgendaOnline.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace AgendaOnline.Infra.Data.EntityConfig
{
    public class LogUsuarioConfig :  EntityTypeConfiguration<LogUsuario>
    {
        public LogUsuarioConfig()
        {
            HasKey(log => log.IdLog);
            Property(log => log.Login).HasMaxLength(20);
            Property(log => log.Operacao).HasMaxLength(30);
            Property(log => log.Valor).HasMaxLength(500);
        }
    }
}
