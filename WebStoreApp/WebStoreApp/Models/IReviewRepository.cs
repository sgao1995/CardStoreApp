using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreApp.Models
{
    public interface IReviewRepository
    {
        IEnumerable<Review> Reviews { get; }
        Review GetReviewById(int reviewId); //return a review by its id

    }
}
