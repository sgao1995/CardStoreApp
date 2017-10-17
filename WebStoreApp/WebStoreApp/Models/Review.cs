using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreApp.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        public int CardId { get; set; }

        public string ReviewerName { get; set; }

        public DateTime ReviewDate { get; set; }

        public string Content { get; set; }

        public int Rating { get; set; }

    }
}
