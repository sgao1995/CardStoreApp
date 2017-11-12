using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreApp.Models
{
    public class CardRepository : ICardRepository
    {
        private readonly AppDbContext _appDbContext;

        public CardRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Card> Cards
        {
            get
            {
                return _appDbContext.Cards.Include(c => c.Category);
            }
        }

        public IEnumerable<Card> FeaturedCards
        {
            get
            {
                return _appDbContext.Cards.Include(c => c.Category).Where(card => card.IsFeatured);
            }
        }
        
        public Card GetCardById(int cardId)
        {
            return _appDbContext.Cards.FirstOrDefault(card => card.CardId == cardId);
        }
    }
}
