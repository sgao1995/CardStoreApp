using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreApp.Models
{
    public interface IReviewRepository
    {
        IEnumerable<Review> Reviews { get; }
    }
}
