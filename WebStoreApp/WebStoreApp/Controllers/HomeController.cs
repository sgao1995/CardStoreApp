using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStoreApp.Models;
using WebStoreApp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebStoreApp.Controllers
{
    public class HomeController : Controller
    {
        //use these in view
        private readonly ICardRepository _cardRepository;
        private readonly ICategoryRepository _categoryRepository;

        public HomeController(ICategoryRepository categoryRepo, ICardRepository cardRepo)
        {
            _cardRepository = cardRepo;
            _categoryRepository = categoryRepo;
        }
        // GET: /<controller>/
        public ViewResult Catalogue()
        {
            CardsCatalogueViewModel cardsCatalogueViewModel = new CardsCatalogueViewModel();
            cardsCatalogueViewModel.Cards = _cardRepository.Cards;
            cardsCatalogueViewModel.CurrentCategory = "Monster Cards";
            return View(cardsCatalogueViewModel); 
        }
    }
}
