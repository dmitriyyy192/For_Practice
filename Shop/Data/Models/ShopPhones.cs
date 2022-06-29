using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Models
{
    public class ShopPhones
    {
        private readonly AppDBContent appDBContent;

        public ShopPhones(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string ShopPhoneId { get; set; }

        public List<ShopPhonesItem> listShopItems { get; set; }

        public static ShopPhones GetPhone(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();

            string shopPhoneId = session.GetString("PhoneId") ?? Guid.NewGuid().ToString();

            session.SetString("PhoneId", shopPhoneId);

            return new ShopPhones(context) { ShopPhoneId = shopPhoneId };
        }

        public void AddToPhone(Phone phone)
        {
            this.appDBContent.ShopPhonesItem.Add(new ShopPhonesItem
            {
                ShopPhoneId = ShopPhoneId,
                phone = phone,
                price = phone.price,
            });

            appDBContent.SaveChanges();
        }
        public List<ShopPhonesItem> getShopItems()
        {
            return appDBContent.ShopPhonesItem.Where(c => c.ShopPhoneId == ShopPhoneId).Include(s => s.phone).ToList();
        }
    }
}
