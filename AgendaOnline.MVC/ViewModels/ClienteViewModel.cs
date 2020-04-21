using AgendaOnline.Dominio.Entidades;
using AgendaOnline.MVC.Controllers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgendaOnline.MVC.ViewModels
{
    public class ClienteViewModel
    {
        public int IdCliente { get; set; }
        [Display(Name = "Razão Social")]
        [Required(ErrorMessage = "Informe a razão social.")]
        [StringLength(100, ErrorMessage = "O login deve ter no maximo 100 caracteres")]
        public string RazaoSocial { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Informe o e-mail.")]
        [StringLength(30, ErrorMessage = "O e-mail deve ter no maximo 30 caracteres")]
        public string Email { get; set; }

        public string WebSite { get; set; }

        [Required(ErrorMessage = "Informe o contato.")]
        [StringLength(30, ErrorMessage = "O contato deve ter no maximo 30 caracteres")]
        public string Contato { get; set; }

        [Required(ErrorMessage = "Informe o telefone.")]
        public string Telefone { get; set; }

        public string Celular { get; set; }

        [Display(Name = "Ativo")]
        public bool ativo { get; set; }

        public virtual IEnumerable<HistoricoViewModel> Historico { get; set; }

    }
}