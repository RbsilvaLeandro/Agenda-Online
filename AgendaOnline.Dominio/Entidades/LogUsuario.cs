using System;

namespace AgendaOnline.Dominio.Entidades
{
    public class LogUsuario
    {
        public int IdLog { get; set; }
        public string Login { get; set; }
        public DateTime Data { get; set; }
        public string Operacao { get; set; }
        public string Valor { get; set; }
        public string Host { get; set; }
    }
}
