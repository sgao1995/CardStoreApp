using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreApp.Models
{
    public class ReviewRepository : IReviewRepository
    {
        public IEnumerable<Review> Reviews
        {
            get
            {
                return new List<Review>
                {
                    new Review{ReviewId = 1, ReviewerName = "CardExpert", ReviewDate = DateTime.Now, Content = " This card is good", Rating = 5 },
                    new Review{ReviewId = 2, ReviewerName = "CardExpert", ReviewDate = DateTime.Now, Content = " This card is okay", Rating = 3 },
                    new Review{ReviewId = 3, ReviewerName = "CardExpert", ReviewDate = DateTime.Now, Content = " This card is bad", Rating = 1 }
                };
            }
        }
    }
}
