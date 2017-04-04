using System;

namespace WeddingShop.Data.Models
{
    public class Article
    {
        public Guid Id { get; set; }
        
        public string Title { get; set; }
        
        public string Author { get; set; }
        
        public string Description { get; set; }
    }
}
