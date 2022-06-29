using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;

namespace Shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {

        private readonly AppDBContent appDBContent;
        private readonly ShopPhones shopPhones;

        public OrdersRepository(AppDBContent appDBContent, ShopPhones shopPhones)
        {
            this.appDBContent = appDBContent;
            this.shopPhones = shopPhones;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();

            var items = shopPhones.listShopItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    PhoneID = el.phone.id,
                    orderID = order.id,
                    price = el.phone.price
                };

                appDBContent.OrderDetail.Add(orderDetail);
            }

            appDBContent.SaveChanges();
        }
    }
}
