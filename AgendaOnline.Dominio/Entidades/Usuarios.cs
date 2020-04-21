namespace AgendaOnline.Dominio.Entidades
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool FlagSenha { get; set; }
    }
}
