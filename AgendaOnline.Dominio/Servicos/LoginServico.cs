using AgendaOnline.Dominio.Entidades;
using AgendaOnline.Dominio.Interfaces.Repositorios;
using AgendaOnline.Dominio.Interfaces.Servicos;

namespace AgendaOnline.Dominio.Servicos
{
    public class LoginServico : ServicoBase<Usuarios>, ILoginServico
    {
        private ILoginRepositorio _LoginRepositorio;
        public LoginServico(ILoginRepositorio LoginRepositorio)
            : base(LoginRepositorio)
        {
            _LoginRepositorio = LoginRepositorio;
        }

        public Usuarios Login(Usuarios usuario)
        {
            return _LoginRepositorio.Login(usuario);
        }
    }
}
