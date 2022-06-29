using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

                       

            if(!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Category.Any())
            {
                content.AddRange(
                    new Phone
                    {
                        name = "iPhone 13 Pro Max",
                        shortDesc = "Новейшая модель",
                        longDesc = "Отличный дизайн, лучшая производительность, дешёвая цена",
                        img = "/img/1.jpg",
                        price = 6000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["IOS"],
                    },

                    new Phone
                    {
                        name = "iPhone 11 Pro Max",
                        shortDesc = "Отличный телефон",
                        longDesc = "Современный телефон с хорошей камерой и производительностью от компании Apple",
                        img = "/img/2.jpg",
                        price = 2000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["IOS"],
                    },

                    new Phone
                    {
                        name = "Xiaomi 11T Pro",
                        shortDesc = "Народный телефон",
                        longDesc = "Современный телефон, дизайн на высоте, по доступной цене",
                        img = "/img/3.png",
                        price = 2200,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Android"],
                    },

                    new Phone
                    {
                        name = "Samsung Galaxy S22 Ultra",
                        shortDesc = "Отличный телефон, который подойдёт всем",
                        longDesc = "Современный телефон с хорошим дизайном от компании Samsung",
                        img = "/img/4.webp",
                        price = 3500,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Android"],
                    },

                    new Phone
                    {
                        name = "Microsoft Lumia 950 XL",
                        shortDesc = "Устаревший телефон",
                        longDesc = "Устаревший, но стабильно работающий телефон от компании Microsoft",
                        img = "/img/5.jpg",
                        price = 600,
                        isFavourite = true,
                        available = true,
                        Category = Categories["WindowsPhone"],
                    },

                    new Phone
                    {
                        name = "Nokia Lumia 1020",
                        shortDesc = "Устаревший телефон",
                        longDesc = "Хороший телефон за низкую ценю от компании Nokia",
                        img = "/img/6.webp",
                        price = 242,
                        isFavourite = false,
                        available = true,
                        Category = Categories["WindowsPhone"],
                    }
               );
            }

            content.SaveChanges();

        }

        public static Dictionary<string, Category> category; 
        public static Dictionary<string,Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "IOS", desc = "Самая известная ОС для телефона"},
                    new Category { categoryName = "WindowsPhone", desc = "Не самая популярная ОС в наши дни"},
                    new Category { categoryName = "Android", desc = "Самая народная ОС для телефона"},
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName,el);
                    }
                }

                return category;
            }
        }
     }
}
