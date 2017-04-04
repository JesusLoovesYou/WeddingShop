using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WeddingShop.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace WeddingShop.IntegrationTests
{
    [SetUpFixture]
    public class TestsInitializer
    {
        [OneTimeSetUp]
        public static void AssemblyInit(TestContext context)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WeddingShopEfDbContext, TestDbConfiguration>());
        }
    }

    public sealed class TestDbConfiguration : DbMigrationsConfiguration<WeddingShopEfDbContext>
    {
        public TestDbConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }
    }
}
