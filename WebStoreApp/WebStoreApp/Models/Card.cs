using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreApp.Models
{
    public class Card
    {
        public int CardId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Attribute { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public string Type { get; set; }

        public int Level { get; set; }

        public string EffectText { get; set; }

        public decimal Price { get; set; }

        public bool IsFeatured { get; set; }

        public bool IsInStock { get; set; }

        public string ImgUrl { get; set; }

        public string ThumbnailUrl { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}
