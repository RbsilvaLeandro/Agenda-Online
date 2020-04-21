using System;

namespace AgendaOnline.Dominio.Entidades
{
    public class Historico
    {
        public int IdHistorico { get; set; }
        public int ClienteId { get; set; }
        public string HistoricoDescricao { get; set; }
        public DateTime DataContato { get; set; }
        public string Obs { get; set; }
        public virtual Clientes Clientes { get; set; }
    }
}
