using System;
using System.Web.Mvc;
using WeddingShop.Web.Common.AutoMapping;

namespace WeddingShop.Web.ViewModels.Article
{
    public class ArticleViewModel : IMapFrom<Data.Models.Article>
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        [AllowHtml]
        public string Description { get; set; }
        // test
    }
}