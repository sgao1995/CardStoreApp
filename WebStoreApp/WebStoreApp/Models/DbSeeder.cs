using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreApp.Models
{
    public static class DbSeeder
    {
        private static Dictionary<string, Category> categories;
        private static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var types = new Category[]
                    {
                        new Category{CategoryName = "Spell Cards"},
                        new Category{CategoryName = "Trap Cards"},
                        new Category{CategoryName = "Monster Cards"}
                    };
                    categories = new Dictionary<string, Category>();

                    foreach (Category t in types)
                    {
                        categories.Add(t.CategoryName, t);
                    }
                }
                return categories;
            }
        }
      
        public static void Seed(IApplicationBuilder appBuilder)
        {
            AppDbContext context = appBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any()) //if there are no categories in db, add categories
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }
            if (!context.Cards.Any()) // if there are no cards in db, add cards
            {
                context.AddRange
                (
                    new Card
                    {
                        Name = "Dark Magician",
                        Description = "Dark Magician is a class card, a very strong normal monster",
                        Attribute = "Dark",
                        Attack = 2500,
                        Defense = 2100,
                        Type = "Spellcaster/Normal",
                        Level = 7,
                        EffectText = "The ultimate wizard in terms of attack and defense",
                        Price = 0.1M,
                        IsFeatured = true,
                        IsInStock = true,
                        ThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSuOaseovz-F4wruqlFXLqYNjkDKUpNnu8BeEMudh6z0N0vtJSDkA",
                        Category = Categories["Monster Cards"]
                    },
                    new Card
                    {
                        Name = "Eternal Soul",
                        Description = "A trap card used to support Dark Magician, allows easy search and summoning of Dark Magician",
                        Attribute = "Trap",
                        Type = "Trap/Continuous",
                        Level = 7,
                        EffectText = "Placeholder",
                        Price = 0.2M,
                        IsFeatured = false,
                        IsInStock = true,
                        ThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTXAFV-aZ38lMMhkjRKALrIOnsVHAxDA6ZOMLkJH86YFzCxaqyvOw",
                        Category = Categories["Trap Cards"]
                    },
                    new Card
                    {
                        Name = "Dark Magical Circle",
                        Description = "Spell card support for Dark Magician, allows easier way to search for Dark Magician, also allows player to banish an opponent's card after summoning Dark Magician",
                        Attribute = "Spell",
                        Type = "Spell/Continuous",
                        Level = 7,
                        EffectText = "Placeholder",
                        Price = 0.15M,
                        IsFeatured = false,
                        IsInStock = true,
                        ThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaoyis285j4MVnvdt85v42PRO6G6CMDsfv8BYvHhlLpVSkWzE1EA",
                        Category = Categories["Spell Cards"]
                    }
                );
            }
            //seeder data for reviews, in case need to test
                    /*new Review { ReviewId = 1, ReviewerName = "CardExpert", ReviewDate = DateTime.Now, Content = " This card is good", Rating = 5 },
                    new Review { ReviewId = 2, ReviewerName = "CardExpert", ReviewDate = DateTime.Now, Content = " This card is okay", Rating = 3 },
                    new Review { ReviewId = 3, ReviewerName = "CardExpert", ReviewDate = DateTime.Now, Content = " This card is bad", Rating = 1 }*/
            context.SaveChanges();
        }
    }
}
