[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WeddingShop.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(WeddingShop.Web.App_Start.NinjectWebCommon), "Stop")]

namespace WeddingShop.Web.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using WeddingShop.Auth.Contracts;
    using Microsoft.AspNet.Identity.Owin;
    using WeddingShop.Auth;
    using WeddingShop.Data;
    using WeddingShop.Data.Contracts;
    using WeddingShop.Data.EfDbSetWrappers;

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
            kernel.Bind<IWeddingShopEfDbContextSaveChanges>().To<WeddingShopEfDbContext>().InRequestScope();
            
            kernel.Bind<ISignInService>().ToMethod(_ => HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>());
            kernel.Bind<IUserService>().ToMethod(_ => HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>());

            kernel.Bind(typeof(IEfDbSetWrapper<>)).To(typeof(EfDbSetWrapper<>));
        }        
    }
}
