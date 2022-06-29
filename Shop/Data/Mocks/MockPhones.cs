using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Mocks
{
    public class MockPhones : IAllPhones
    {

        private readonly IPhonesCategory _categoryPhones = new MockCategory(); 

        public IEnumerable<Phone> Phones
        {
            get
            {
                return new List<Phone>
                {
                    new Phone
                    {
                        name = "iPhone 13 Pro Max",
                        shortDesc = "Новейшая модель",
                        longDesc = "Отличный дизайн, лучшая производительность, дешёвая цена",
                        img = "https://nsv.by/upload/image_resize/579/369/8de298167f217b77f4122881c0844191.jpg",
                        price = 6000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryPhones.AllCategories.First(),
                    },

                    new Phone
                    {
                        name = "iPhone 11 Pro Max",
                        shortDesc = "Отличный телефон",
                        longDesc = "Современный телефон с хорошей камерой и производительностью от компании Apple",
                        img = "https://shop.by/images/apple_iphone_11_pro_max_512gb_dual_sim_silver_1.jpg",
                        price = 2000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryPhones.AllCategories.First(),
                    },

                    new Phone
                    {
                        name = "Xiaomi 11T Pro",
                        shortDesc = "Народный телефон",
                        longDesc = "Современный телефон, дизайн на высоте, по доступной цене",
                        img = "https://i01.appmifile.com/webfile/globalimg/Iris/xiaomi-11t-pro-black.png",
                        price = 2200,
                        isFavourite = true,
                        available = true,
                        Category = _categoryPhones.AllCategories.Last(),
                    },

                    new Phone
                    {
                        name = "Samsung Galaxy S22 Ultra",
                        shortDesc = "Отличный телефон, который подойдёт всем",
                        longDesc = "Современный телефон с хорошим дизайном от компании Samsung",
                        img = "https://mobistore.by/files/products/1/samsung-galaxy-s22-ultra-5g-128gb-pr27696.jpg.400x400.webp?f6a15811afe3bcb7c0c6383c2b68a400",
                        price = 3500,
                        isFavourite = false,
                        available = true,
                        Category = _categoryPhones.AllCategories.Last(),
                    },

                    new Phone
                    {
                        name = "Microsoft Lumia 950 XL",
                        shortDesc = "Устаревший телефон",
                        longDesc = "Устаревший, но стабильно работающий телефон от компании Microsoft",
                        img = "https://www.notebookcheck-ru.com/uploads/tx_nbc2/MicrosolfLumia950XL.jpg",
                        price = 600,
                        isFavourite = true,
                        available = true,
                        Category = _categoryPhones.AllCategories.ElementAt(1),
                    },

                    new Phone
                    {
                        name = "Nokia Lumia 1020",
                        shortDesc = "Устаревший телефон",
                        longDesc = "Хороший телефон за низкую ценю от компании Nokia",
                        img = "https://chipmaster.by/components/com_jshopping/files/img_products/full_Nokia_Lumia_1020.webp",
                        price = 242,
                        isFavourite = false,
                        available = true,
                        Category = _categoryPhones.AllCategories.ElementAt(1),
                    }

                };
            }
        }
        public IEnumerable<Phone> getFavPhones { get; set ; }

        public Phone getObjectPhone(int phoneId)
        {
            throw new System.NotImplementedException();
        }
    }
}
