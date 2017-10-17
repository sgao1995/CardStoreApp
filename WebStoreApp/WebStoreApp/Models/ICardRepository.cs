using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreApp.Models
{
    public interface ICardRepository
    {
        IEnumerable<Card> Cards { get; }

        IEnumerable<Card> FeaturedCards { get; }

        Card GetCardById(int cardId); //return a card by its id
    }
}
