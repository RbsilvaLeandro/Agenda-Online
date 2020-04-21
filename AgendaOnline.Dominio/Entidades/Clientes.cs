using System.Collections.Generic;

namespace AgendaOnline.Dominio.Entidades
{
    public class Clientes
    {
        public int IdCliente { get; set; }
        public string RazaoSocial { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public bool ativo { get; set; }

        public virtual IEnumerable<Enderecos> Endereco { get; set; }
        public virtual IEnumerable<Historico> Historicos { get; set; }
        public virtual IEnumerable<Lembretes> Lembretes { get; set; }
    }
}
