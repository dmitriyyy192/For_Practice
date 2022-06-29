using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Mocks
{
    public class MockCategory : IPhonesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "IOS", desc = "Самая известная ОС для телефона"},
                    new Category { categoryName = "WindowsPhone", desc = "Не самая популярная ОС в наши дни"},
                    new Category { categoryName = "Android", desc = "Самая народная ОС для телефона"},
                };
            }
        }
    }
}
