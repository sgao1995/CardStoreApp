using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreApp.Models
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly AppDbContext _appDbContext;

        public ReviewRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Review> Reviews => _appDbContext.Reviews;
     
        public Review GetReviewById(int reviewId)
        {
            return _appDbContext.Reviews.FirstOrDefault(review => review.ReviewId == reviewId);
        }
    }
}
