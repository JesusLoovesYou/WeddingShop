using System.Web.Mvc;

namespace WeddingShop.Web.App_Start
{
    public class ViewEngineConfig
    {
        public static void RegisterViewEngines(ViewEngineCollection viewEngines)
        {
            viewEngines.Clear();

            viewEngines.Add(new RazorViewEngine());
        }
    }
}