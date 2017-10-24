using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreApp.Models
{
    public class CardRepository : ICardRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();

        public IEnumerable<Card> FeaturedCards { get; }

        public IEnumerable<Card> Cards
        {
            get
            {
                return new List<Card>
                {
                    new Card {
                        CardId = 1,
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
                        Category = _categoryRepository.Categories.ToList()[2] },
                    new Card {
                        CardId = 2,
                        Name = "Eternal Soul",
                        Description = "A trap card used to support Dark Magician, allows easy search and summoning of Dark Magician",
                        Attribute = "Trap",
                        Type = "Trap/Continuous",
                        Level = 7,
                        EffectText ="Placeholder",
                        Price = 0.2M,
                        IsFeatured = false,
                        IsInStock = true,
                        ThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTXAFV-aZ38lMMhkjRKALrIOnsVHAxDA6ZOMLkJH86YFzCxaqyvOw",
                        Category = _categoryRepository.Categories.ToList()[1]
                    },
                    new Card {
                        CardId = 3,
                        Name = "Dark Magical Circle",
                        Description = "Spell card support for Dark Magician, allows easier way to search for Dark Magician, also allows player to banish an opponent's card after summoning Dark Magician",
                        Attribute = "Spell",
                        Type = "Spell/Continuous",
                        Level = 7,
                        EffectText ="Placeholder",
                        Price = 0.15M,
                        IsFeatured = false,
                        IsInStock = true,
                        ThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaoyis285j4MVnvdt85v42PRO6G6CMDsfv8BYvHhlLpVSkWzE1EA",
                        Category = _categoryRepository.Categories.ToList()[0]
                    },
                     new Card {
                        CardId = 3,
                        Name = "Dark Magical Circle",
                        Description = "Spell card support for Dark Magician, allows easier way to search for Dark Magician, also allows player to banish an opponent's card after summoning Dark Magician",
                        Attribute = "Spell",
                        Type = "Spell/Continuous",
                        Level = 7,
                        EffectText ="Placeholder",
                        Price = 0.15M,
                        IsFeatured = false,
                        IsInStock = true,
                        ThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaoyis285j4MVnvdt85v42PRO6G6CMDsfv8BYvHhlLpVSkWzE1EA",
                        Category = _categoryRepository.Categories.ToList()[0]
                     },
                     new Card {
                        CardId = 3,
                        Name = "Dark Magical Circle",
                        Description = "Spell card support for Dark Magician, allows easier way to search for Dark Magician, also allows player to banish an opponent's card after summoning Dark Magician",
                        Attribute = "Spell",
                        Type = "Spell/Continuous",
                        Level = 7,
                        EffectText ="Placeholder",
                        Price = 0.15M,
                        IsFeatured = false,
                        IsInStock = true,
                        ThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaoyis285j4MVnvdt85v42PRO6G6CMDsfv8BYvHhlLpVSkWzE1EA",
                        Category = _categoryRepository.Categories.ToList()[0]
                     },
                     new Card {
                        CardId = 3,
                        Name = "Dark Magical Circle",
                        Description = "Spell card support for Dark Magician, allows easier way to search for Dark Magician, also allows player to banish an opponent's card after summoning Dark Magician",
                        Attribute = "Spell",
                        Type = "Spell/Continuous",
                        Level = 7,
                        EffectText ="Placeholder",
                        Price = 0.15M,
                        IsFeatured = false,
                        IsInStock = true,
                        ThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaoyis285j4MVnvdt85v42PRO6G6CMDsfv8BYvHhlLpVSkWzE1EA",
                        Category = _categoryRepository.Categories.ToList()[0]
                     },
                     new Card {
                        CardId = 3,
                        Name = "Dark Magical Circle",
                        Description = "Spell card support for Dark Magician, allows easier way to search for Dark Magician, also allows player to banish an opponent's card after summoning Dark Magician",
                        Attribute = "Spell",
                        Type = "Spell/Continuous",
                        Level = 7,
                        EffectText ="Placeholder",
                        Price = 0.15M,
                        IsFeatured = false,
                        IsInStock = true,
                        ThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaoyis285j4MVnvdt85v42PRO6G6CMDsfv8BYvHhlLpVSkWzE1EA",
                        Category = _categoryRepository.Categories.ToList()[0]
                     },
                     new Card {
                        CardId = 3,
                        Name = "Dark Magical Circle",
                        Description = "Spell card support for Dark Magician, allows easier way to search for Dark Magician, also allows player to banish an opponent's card after summoning Dark Magician",
                        Attribute = "Spell",
                        Type = "Spell/Continuous",
                        Level = 7,
                        EffectText ="Placeholder",
                        Price = 0.15M,
                        IsFeatured = false,
                        IsInStock = true,
                        ThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaoyis285j4MVnvdt85v42PRO6G6CMDsfv8BYvHhlLpVSkWzE1EA",
                        Category = _categoryRepository.Categories.ToList()[0]
                     },
                     new Card {
                        CardId = 3,
                        Name = "Dark Magical Circle",
                        Description = "Spell card support for Dark Magician, allows easier way to search for Dark Magician, also allows player to banish an opponent's card after summoning Dark Magician",
                        Attribute = "Spell",
                        Type = "Spell/Continuous",
                        Level = 7,
                        EffectText ="Placeholder",
                        Price = 0.15M,
                        IsFeatured = false,
                        IsInStock = true,
                        ThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaoyis285j4MVnvdt85v42PRO6G6CMDsfv8BYvHhlLpVSkWzE1EA",
                        Category = _categoryRepository.Categories.ToList()[0]
                     },
                     new Card {
                        CardId = 3,
                        Name = "Dark Magical Circle",
                        Description = "Spell card support for Dark Magician, allows easier way to search for Dark Magician, also allows player to banish an opponent's card after summoning Dark Magician",
                        Attribute = "Spell",
                        Type = "Spell/Continuous",
                        Level = 7,
                        EffectText ="Placeholder",
                        Price = 0.15M,
                        IsFeatured = false,
                        IsInStock = true,
                        ThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaoyis285j4MVnvdt85v42PRO6G6CMDsfv8BYvHhlLpVSkWzE1EA",
                        Category = _categoryRepository.Categories.ToList()[0]
                     },
                     new Card {
                        CardId = 3,
                        Name = "Dark Magical Circle",
                        Description = "Spell card support for Dark Magician, allows easier way to search for Dark Magician, also allows player to banish an opponent's card after summoning Dark Magician",
                        Attribute = "Spell",
                        Type = "Spell/Continuous",
                        Level = 7,
                        EffectText ="Placeholder",
                        Price = 0.15M,
                        IsFeatured = false,
                        IsInStock = true,
                        ThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaoyis285j4MVnvdt85v42PRO6G6CMDsfv8BYvHhlLpVSkWzE1EA",
                        Category = _categoryRepository.Categories.ToList()[0]
                     }






                };
            }
        }

        public Card GetCardById(int cardId)
        {
            throw new NotImplementedException();
        }
    }
}
