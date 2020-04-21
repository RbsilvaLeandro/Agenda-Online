using AgendaOnline.Dominio.Entidades;

namespace AgendaOnline.Aplicacao.Interface
{
    public interface ILoginAppServico : IAppServicoBase<Usuarios>
    {
        Usuarios Login(Usuarios usuario);
    }
}
