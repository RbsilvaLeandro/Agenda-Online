
using AgendaOnline.Dominio.Entidades;
using AgendaOnline.Dominio.Interfaces.Repositorios;
using AgendaOnline.Infra.Data.Contexto;
using System.Linq;


namespace AgendaOnline.Infra.Data.Repositorios
{
    public class LoginRepositorio : RepositorioBase<Usuarios>, ILoginRepositorio
    {
       
        public Usuarios Login(Usuarios usuario)
        {
            using (var contexto = new AgendaOnlineContexto())
            {
                return contexto.Usuarios.FirstOrDefault(u => u.Login == usuario.Login && u.Senha == usuario.Senha);
            }
        }      
    }
}
