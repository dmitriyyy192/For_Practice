using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System.Linq;

namespace Shop.Controllers
{
    public class ShopPhoneController : Controller
    {
        private readonly IAllPhones _phoneRep;
        private readonly ShopPhones _shopPhones;

        public ShopPhoneController(IAllPhones phoneRep, ShopPhones shopPhones)
        {
            _phoneRep = phoneRep;
            _shopPhones = shopPhones; 
        }

        public ViewResult Index()
        {
            var items = _shopPhones.getShopItems();
            _shopPhones.listShopItems = items;

            var obj = new ShopPhoneViewModel
            {
                shopPhones = _shopPhones
            };
            return View(obj);
        }

        public RedirectToActionResult addToPhone(int id)
        {
            var item = _phoneRep.Phones.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopPhones.AddToPhone(item);
            }

            return RedirectToAction("Index");
        }
    }
}
