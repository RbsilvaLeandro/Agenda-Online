using AgendaOnline.Dominio.Entidades;

namespace AgendaOnline.Dominio.Interfaces.Repositorios
{
    public interface ILoginRepositorio : IRepositorioBase<Usuarios>
    {
        Usuarios Login(Usuarios usuario);
    }
}
