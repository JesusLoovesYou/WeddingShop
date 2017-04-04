using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WeddingShop.Data.Contracts;
using WeddingShop.Data.Models;

namespace WeddingShop.Data
{
    public class WeddingShopEfDbContext : DbContext, IWeddingShopEfDbContextSaveChanges
    {
        public WeddingShopEfDbContext() 
            : base("WeddingShopDb")
        {
        }

        public new IDbSet<T> Set<T>()
           where T : class
        {
            return base.Set<T>();
        }

        public IDbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //this.OnArticleCreating(modelBuilder);
        }

        //private void OnArticleCreating(DbModelBuilder modelBuilder)
        //{
        //    // TO DO
        //    //modelBuilder.Entity<Book>()
        //    //    .HasKey(b => b.Id)
        //    //    .Property(b => b.Id)
        //    //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

        //    modelBuilder.Entity<Article>()
        //        .Property(b => b.Author).IsOptional();

        //    modelBuilder.Entity<Article>()
        //        .Property(b => b.Title).IsRequired();
            
        //}
    }
}
