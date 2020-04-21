using AgendaOnline.MVC.ViewModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace AgendaOnline.MVC.Controllers
{
    public class HistoricoViewModel
    {
        public int ClienteId { get; set; }
        [Display(Name ="Descrição")]
        public string HistoricoDescricao { get; set; }
        [Display(Name = "Data Contato")]
        public DateTime DataContato { get; set; }
        [Display(Name = "Observação")]
        public string Obs { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}