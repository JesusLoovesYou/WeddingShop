using System.Collections.Generic;
using System.Web.Mvc;
using WeddingShop.DataServises.Contracts;
using WeddingShop.Web.Common.AutoMapping;
using WeddingShop.Web.ViewModels.Article;

namespace WeddingShop.Web.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;

        private readonly IMapperAdapter mapper;

        public ArticleController(IArticleService articleService, IMapperAdapter mapper)
        {
            this.articleService = articleService;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var articles = this.articleService.All();

            var model = this.mapper.Map<IEnumerable<ArticleViewModel>>(articles);

            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ArticleViewModel model)
        {
            return View(model);
        }
    }
}