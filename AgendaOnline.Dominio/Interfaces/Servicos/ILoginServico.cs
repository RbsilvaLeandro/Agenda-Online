using AgendaOnline.Dominio.Entidades;

namespace AgendaOnline.Dominio.Interfaces.Servicos
{
    public interface ILoginServico : IServicoBase<Usuarios>
    {
        Usuarios Login(Usuarios usuario);
    }
}
