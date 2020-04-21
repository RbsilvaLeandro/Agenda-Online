using AgendaOnline.Dominio.Entidades;
using System.Collections.Generic;

namespace AgendaOnline.Dominio.Interfaces.Repositorios
{
    public interface IClienteRepositorio : IRepositorioBase<Clientes>
    {
        IEnumerable<Clientes> ListagemCliente();
    }
}
