﻿namespace Shop.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int PhoneID { get; set; }
        public uint price { get; set; }
        public virtual Phone phone { get; set; }
        public virtual Order order { get; set; }
    }
}
