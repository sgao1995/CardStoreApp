using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreApp.Models;

namespace WebStoreApp.ViewModels
{
    public class CardsCatalogueViewModel
    {
        public IEnumerable<Card> Cards { get; set; }

        public string CurrentCategory { get; set; }
    }
}
