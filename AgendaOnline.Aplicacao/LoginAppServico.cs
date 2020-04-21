using AgendaOnline.Aplicacao.Interface;
using AgendaOnline.Dominio.Entidades;
using AgendaOnline.Dominio.Interfaces.Servicos;


namespace AgendaOnline.Aplicacao
{
    public class LoginAppServico : AppServicoBase<Usuarios>, ILoginAppServico
    {
        private readonly ILoginServico _LoginServico;
        public LoginAppServico(ILoginServico loginServico)
            : base(loginServico)
        {
            _LoginServico = loginServico;
        }
        public Usuarios Login(Usuarios usuario)
        {
            return _LoginServico.Login(usuario);
        }       
    }
}
