using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using WeddingShop.Data.Models;

namespace WeddingShop.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<WeddingShopEfDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(WeddingShopEfDbContext context)
        {
            if (context.Articles.Any())
            {
                return;
            }
            
            var articles = new List<Article>()
            {
                new Article() {
                    Id = Guid.NewGuid(),
                    Title = "Fundamentals of Computer Programming with C#",
                    Author = "Svetlin Nakov & Co.",
                    Description = "The free book \"Fundamentals of Computer Programming with C#\" aims to provide novice programmers solid foundation of basic knowledge regardless of the programming language. This book covers the fundamentals of programming that have not changed significantly over the last 10 years. Educational content was developed by an authoritative author team led by Svetlin Nakov and covers topics such as variables conditional statements, loops and arrays, and more complex concepts such as data structures (lists, stacks, queues, trees, hash tables, etc.), and recursion recursive algorithms, object-oriented programming and high-quality code. From the book you will learn how to think as programmers and how to solve efficiently programming problems. You will master the fundamental principles of programming and basic data structures and algorithms, without which you can't become a software engineer."
                },
                new Article() {
                    Id = Guid.NewGuid(),
                    Title = "C# Yellow Article",
                    Author = "Rob Miles",
                    Description = "The C# Article is used by the Department of Computer Science in the University of Hull as the basis of the First Year programming course."
                },
                new Article() {
                    Id = Guid.NewGuid(),
                    Title = "Programming = ++ Algorithms;",
                    Author = "Preslav Nakov and Panayot Dobrikov",
                    Description = "The “Programming=++Algorithms;” book is now available for free download as PDF. Everyone who speaks Bulgarian could benefit from the free non-commercial edition of this highly-valuable book on algorithms and competitive programming."
                },
                new Article() {
                    Id = Guid.NewGuid(),
                    Title = "SQL in a Nutshell: A Desktop Quick Reference",
                    Author = "Kevin Kline"
                },
                new Article() {
                    Id = Guid.NewGuid(),
                    Title = "Beginning HTML and CSS",
                    Author = "Rob Larsen"
                },
                new Article() {
                    Id = Guid.NewGuid(),
                    Title = "Beginning ASP.NET 4.5 in C# Coding Skills Kit",
                    Author = "Imar Spaanjaars"
                },
                new Article() {
                    Id = Guid.NewGuid(),
                    Title = "Advanced Linux Programming",
                    Author = "CodeSourcery LLC"
                },
            };

            context.Articles.AddOrUpdate(articles.ToArray());
            context.SaveChanges();
        }
    }
}
