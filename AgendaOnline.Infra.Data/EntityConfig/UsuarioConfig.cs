using AgendaOnline.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;
using System.Linq;


namespace AgendaOnline.Infra.Data.EntityConfig
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuarios>
    {
        public UsuarioConfig()
        {
            HasKey(u => u.IdUsuario);
            Property(u => u.Nome).IsRequired().HasMaxLength(100);
            Property(u => u.Senha).IsRequired().HasMaxLength(30);
            Property(u => u.Login).IsRequired().HasMaxLength(50);
            Property(u => u.Email).IsRequired().HasMaxLength(70);
        }
    }
}
