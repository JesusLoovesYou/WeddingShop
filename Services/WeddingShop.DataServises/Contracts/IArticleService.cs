using System;
using System.Collections.Generic;
using WeddingShop.Data.Models;

namespace WeddingShop.DataServises.Contracts
{
    public interface IArticleService
    {
        IEnumerable<Article> All();

        Article GetById(Guid id);
    }
}