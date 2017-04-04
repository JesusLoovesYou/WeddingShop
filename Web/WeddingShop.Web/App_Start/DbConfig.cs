using System.Data.Entity;
using WeddingShop.Data;
using WeddingShop.Data.Migrations;

namespace WeddingShop.Web.App_Start
{
    public class DbConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WeddingShopEfDbContext, Configuration>());
        }
    }
}