using AgendaOnline.Dominio.Entidades;
using AgendaOnline.Dominio.Interfaces.Repositorios;
using AgendaOnline.Dominio.Interfaces.Servicos;
using System.Collections.Generic;

namespace AgendaOnline.Dominio.Servicos
{
    public class ClienteServico : ServicoBase<Clientes>, IClienteServico
    {
        private readonly IClienteRepositorio _ClienteRepositorio;

        public ClienteServico(IClienteRepositorio ClienteRepositorio) : base(ClienteRepositorio)
        {
            _ClienteRepositorio = ClienteRepositorio;
        }

        public IEnumerable<Clientes> ListagemCliente()
        {
            return _ClienteRepositorio.ListagemCliente();
        }
    }
}
