using AgendaOnline.Aplicacao.Interface;
using AgendaOnline.Dominio.Entidades;
using AgendaOnline.Dominio.Interfaces.Servicos;
using System.Collections.Generic;

namespace AgendaOnline.Aplicacao
{
    public class ClienteAppServico : AppServicoBase<Clientes>, IClienteAppServico
    {
        private readonly IClienteServico _ClienteServico;

        public ClienteAppServico(IClienteServico clienteServico) : base(clienteServico)
        {
            _ClienteServico = clienteServico;
        }

        public IEnumerable<Clientes> ListaClientes()
        {
            return _ClienteServico.ListagemCliente();
        }
    }
}
