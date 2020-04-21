using AgendaOnline.Dominio.Entidades;
using System.Collections.Generic;

namespace AgendaOnline.Dominio.Interfaces.Servicos
{
    public interface IClienteServico : IServicoBase<Clientes>
    {
        IEnumerable<Clientes> ListagemCliente();        
    }
}
