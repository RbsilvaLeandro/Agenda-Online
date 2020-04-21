namespace AgendaOnline.Dominio.Entidades
{
    public class Lembretes
    {
        public int IdLembrete { get; set; }
        public int ClienteId { get; set; }
        public string Lembrete { get; set; }
        public string Alerta { get; set; }
        public bool DesabilitarLembretes { get; set; }
        public virtual Clientes Clientes { get; set; }
    }
}
