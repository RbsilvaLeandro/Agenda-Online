[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(AgendaOnline.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(AgendaOnline.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace AgendaOnline.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using AgendaOnline.Aplicacao.Interface;
    using AgendaOnline.Aplicacao;
    using AgendaOnline.Dominio.Interfaces.Servicos;
    using AgendaOnline.Dominio.Servicos;
    using AgendaOnline.Dominio.Interfaces.Repositorios;
    using AgendaOnline.Infra.Data.Repositorios;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServicoBase<>)).To(typeof(AppServicoBase<>));
            kernel.Bind<ILoginAppServico>().To<LoginAppServico>();
            kernel.Bind<IClienteAppServico>().To<ClienteAppServico>();
            kernel.Bind<IHistoricoAppServico>().To<HistoricoAppServico>();

            kernel.Bind(typeof(IServicoBase<>)).To(typeof(ServicoBase<>));
            kernel.Bind<ILoginServico>().To<LoginServico>();
            kernel.Bind<IClienteServico>().To<ClienteServico>();
            kernel.Bind<IHistoricoServico>().To<HistoricoServico>();

            kernel.Bind(typeof(IRepositorioBase<>)).To(typeof(RepositorioBase<>));
            kernel.Bind<ILoginRepositorio>().To<LoginRepositorio>();
            kernel.Bind<IClienteRepositorio>().To<ClienteRepositorio>();
            kernel.Bind<IHistoricoRepositorio>().To<HistoricoRepositorio>();
        }        
    }
}
