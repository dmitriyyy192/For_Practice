using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopPhones shopPhones;

        public OrderController(IAllOrders allOrders, ShopPhones shopPhones)
        {
            this.allOrders = allOrders;
            this.shopPhones = shopPhones;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopPhones.listShopItems = shopPhones.getShopItems();

            if(shopPhones.listShopItems.Count == 0)
            {
                ModelState.AddModelError("","У Вас должны быть товары!");
            }

            if(ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        } 

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан!";
            return View();
        }
    }
}
