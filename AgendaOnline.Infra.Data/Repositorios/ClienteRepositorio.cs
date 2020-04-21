using AgendaOnline.Dominio.Entidades;
using AgendaOnline.Dominio.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace AgendaOnline.Infra.Data.Repositorios
{
    public class ClienteRepositorio : RepositorioBase<Clientes>, IClienteRepositorio
    {
       
        public IEnumerable<Clientes> ListagemCliente()
        {
            //var query = db.Produto
            //             .Join(db.Categoria, p => p.IdProduto, c => c.IdCategoria, (p, c) => new { p, c })
            //             .Where(w => w.p.NomeProduto.Contains(Nome))
            //             .Select(s => new Dados()
            //             {
            //                 Nome = s.p.NomeProduto,
            //                 Preco = s.p.Preco,
            //                 Categoria = s.c.NomeCategoria,
            //             }).ToList();

            //return query;

            

            return Db.Clientes.Where(c => c.IdCliente == 1);



        }

    }
}


