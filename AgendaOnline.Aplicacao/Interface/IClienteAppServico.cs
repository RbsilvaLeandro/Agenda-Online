using AgendaOnline.Dominio.Entidades;
using System.Collections.Generic;

namespace AgendaOnline.Aplicacao.Interface
{
    public interface IClienteAppServico  : IAppServicoBase<Clientes>
    {       
       IEnumerable<Clientes> ListaClientes();        
    }
}
