using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class PhonesController : Controller
    {
        private readonly IAllPhones _allPhones;
        private readonly IPhonesCategory _phonesCategory;

        public PhonesController(IAllPhones iAllPhones, IPhonesCategory iPhonesCategory)
        {   
            _allPhones = iAllPhones; 
            _phonesCategory = iPhonesCategory;
        }

        public ViewResult List()
        { 
            ViewBag.Title = "Страница с телефонами";
            PhonesListViewModel obj = new PhonesListViewModel();
            obj.allPhones = _allPhones.Phones;
            obj.currCategory = "Телефоны";

            return View(obj);
        }

    }
}
