using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using WeddingShop.Data.Contracts;
using WeddingShop.Data.Models;
using WeddingShop.DataServises.Contracts;

namespace WeddingShop.DataServises
{
    public class ArticleService : IArticleService
    {
        private readonly IEfDbSetWrapper<Article> efArticleWrapper;

        public ArticleService(IEfDbSetWrapper<Article> efArticleWrapper)
        {
            Guard.WhenArgument(efArticleWrapper, nameof(efArticleWrapper)).IsNull().Throw();

            this.efArticleWrapper = efArticleWrapper;
        }

        public IEnumerable<Article> All()
        {
            var articles = this.efArticleWrapper.All;

            return articles;
        }

        public Article GetById(Guid id)
        {
            var article = this.efArticleWrapper.GetById(id);

            return article;
        }
    }
}
