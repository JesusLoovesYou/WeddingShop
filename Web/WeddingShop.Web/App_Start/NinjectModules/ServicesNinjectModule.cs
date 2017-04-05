using Ninject.Modules;
using Ninject.Extensions.Conventions;

namespace WeddingShop.Web.App_Start.NinjectModules
{
    public class ServicesNinjectModule : NinjectModule
    {
        private const string DllName = "WeddingShop.DataServises.dll";

        public override void Load()
        {
            Common autoBindInRequestScope = new Common(DllName);
            this.Bind(autoBindInRequestScope.AutoBindClassesInRequestScope);
        }
    }
}