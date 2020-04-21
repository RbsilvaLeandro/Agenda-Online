namespace AgendaOnline.Dominio.Entidades
{
    public class Enderecos
    {
        public int IdEndereco { get; set; }
        public int ClienteId { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public virtual Clientes Clientes { get; set; }
    }
}
