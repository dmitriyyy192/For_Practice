using System.Collections.Generic;

namespace Shop.Data.Models
{
    public class Category
    {
        public int id { set; get; }//уникальный идентификатор
        public string categoryName { set; get; }//название категории
        public string desc { set; get; }//описание категории
        public List<Phone> phones { set; get; }//список товаров , которые входят в эту категорию

    }
}
