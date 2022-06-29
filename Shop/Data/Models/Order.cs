﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models
{
    public class Order
    {

        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(15)]
        [Required(ErrorMessage ="Длина имени не более 15 символов")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина фамилии не более 15 символов")]
        public string surname { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(30)]
        [Required(ErrorMessage = "Длина адреса не более 130 символов")]
        public string adress { get; set; }

        [Display(Name = "Телефон")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина телефона не более 20 знаков")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(35)]
        [Required(ErrorMessage = "Длина email не более 35 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public  DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
 