using AgendaOnline.Dominio.Entidades;
using AgendaOnline.MVC.Controllers;
using AgendaOnline.MVC.ViewModels;
using AutoMapper;


namespace AgendaOnline.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<LogViewModel, Usuarios>();
                cfg.CreateMap<Usuarios, LogViewModel>();

                cfg.CreateMap<ClienteViewModel, Clientes>();
                cfg.CreateMap<Clientes, ClienteViewModel>();

                cfg.CreateMap<HistoricoViewModel, Historico>();
                cfg.CreateMap<Historico,HistoricoViewModel>();

            });

        }
    }
}