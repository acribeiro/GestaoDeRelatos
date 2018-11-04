using GestaoDeRelatosDDD.Application.Interface;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(GestaoDeRelatosDDD.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(GestaoDeRelatosDDD.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace GestaoDeRelatosDDD.MVC.App_Start
{
    using System;
    using System.Web;
    using GestaoDeRelatosDDD.Application;
    using GestaoDeRelatosDDD.Domain.Interfaces.Repositories;
    using GestaoDeRelatosDDD.Domain.Interfaces.Services;
    using GestaoDeRelatosDDD.Domain.Services;
    using GestaoDeRelatosDDD.Infra.Data.Repositories;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

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
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IEducadorAppService>().To<EducadorAppService>();
            kernel.Bind<IEducandoAppService>().To<EducandoAppService>();
            kernel.Bind<IOficinaAppService>().To<OficinaAppService>();
            kernel.Bind<IProfissaoAppService>().To<ProfissaoAppService>();
            kernel.Bind<IRelatoAppService>().To<RelatoAppService>();
            kernel.Bind<ITecnicoAppService>().To<TecnicoAppService>();
            kernel.Bind<ITurnoAppService>().To<TurnoAppService>();
            kernel.Bind<IUnidadeAppService>().To<UnidadeAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IEducadorService>().To<EducadorService>();
            kernel.Bind<IEducandoService>().To<EducandoService>();
            kernel.Bind<IOficinaService>().To<OficinaService>();
            kernel.Bind<IProfissaoService>().To<ProfissaoService>();
            kernel.Bind<IRelatoService>().To<RelatoService>();
            kernel.Bind<ITecnicoService>().To<TecnicoService>();
            kernel.Bind<ITurnoService>().To<TurnoService>();
            kernel.Bind<IUnidadeService>().To<UnidadeService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IEducadorRepository>().To<EducadorRepository>();
            kernel.Bind<IEducandoRepository>().To<EducandoRepository>();
            kernel.Bind<IOficinaRepository>().To<OficinaRepository>();
            kernel.Bind<IProfissaoRepository>().To<ProfissaoRepository>();
            kernel.Bind<IRelatoRepository>().To<RelatoRepository>();
            kernel.Bind<ITecnicoRepository>().To<TecnicoRepository>();
            kernel.Bind<ITurnoRepository>().To<TurnoRepository>();
            kernel.Bind<IUnidadeRepository>().To<UnidadeRepository>();

        }
    }
}
