using AgendaOnline.Dominio.Entidades;
using AgendaOnline.Dominio.Interfaces.Repositorios;
using AgendaOnline.Dominio.Interfaces.Servicos;

namespace AgendaOnline.Dominio.Servicos
{
    public class HistoricoServico : ServicoBase<Historico>, IHistoricoServico
    {
        private readonly IHistoricoRepositorio _HistoricoRepositorio;

        public HistoricoServico(IHistoricoRepositorio HistoricoRepositorio) : base(HistoricoRepositorio)
        {
            _HistoricoRepositorio = HistoricoRepositorio;
        }

       
    }
}
