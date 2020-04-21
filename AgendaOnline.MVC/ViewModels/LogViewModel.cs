using System.ComponentModel.DataAnnotations;

namespace AgendaOnline.MVC.ViewModels
{
    public class LogViewModel
    {
        [Required(ErrorMessage = "Informe o Login.")]
        [StringLength(30, ErrorMessage = "O login deve ter no maximo 30 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe a Senha.")]
        [StringLength(30, ErrorMessage = "a senha deve ter no máximo 30 caracteres")]
        public string Senha { get; set; }        
    }
}