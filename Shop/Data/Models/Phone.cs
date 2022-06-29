namespace Shop.Data.Models
{
    public class Phone
    {
        public int id { set; get; }//id конкретного товара(телефона)
        public string name { set; get; }//название товара
        public string shortDesc { set; get; }//небольше описание
        public string longDesc { set; get; }//длинное описание
        public string img { set; get; }//картинка телефона(будет выводиться по URL адресу)
        public ushort price { set; get; }//цена
        public bool isFavourite { set; get; }//для отображения лучших товаров на главной страничке
        public bool available { set; get; }//есть ли товар на сайте и сколько единиц осталось
        public int categoryID { set; get; }//для закрепления товара к определённой категории
        public virtual Category Category { set; get; }//создаём объект со всеми значениями
    }
}
