using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreApp.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId = 1, CategoryName = "Spell Cards" },
                    new Category{CategoryId = 2, CategoryName = "Trap Cards" },
                    new Category{CategoryId = 3, CategoryName = "Monster Cards" }
                };
            }
        }
    }
}
