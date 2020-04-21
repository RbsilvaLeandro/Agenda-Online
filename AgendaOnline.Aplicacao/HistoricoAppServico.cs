using AgendaOnline.Aplicacao.Interface;
using AgendaOnline.Dominio.Entidades;
using AgendaOnline.Dominio.Interfaces.Servicos;

namespace AgendaOnline.Aplicacao
{
    public class HistoricoAppServico : AppServicoBase<Historico>, IHistoricoAppServico
    {
        private readonly IHistoricoServico _HistoricoServico;

        public HistoricoAppServico(IHistoricoServico historicoServico) : base(historicoServico)
        {
            _HistoricoServico = historicoServico;
        }

    }
}
