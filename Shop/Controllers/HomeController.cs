using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllPhones _phoneRep;

        public HomeController(IAllPhones phoneRep)
        {
            _phoneRep = phoneRep;
        }

        public ViewResult Index()
        {
            var homePhones = new HomeViewModel
            {
                favPhones = _phoneRep.getFavPhones
            };
            return View(homePhones);
        }
    }
}
