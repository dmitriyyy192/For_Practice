using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Controllers
{
    public class PhonesController : Controller
    {
        private readonly IAllPhones _allPhones;
        private readonly IPhonesCategory _phonesCategory;

        public PhonesController(IAllPhones iAllPhones, IPhonesCategory iPhonesCategory)
        {   
            _allPhones = iAllPhones; 
            _phonesCategory = iPhonesCategory;
        }

        [Route("Phones/List")]
        [Route("Phones/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Phone> phones = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                phones = _allPhones.Phones.OrderBy(i => i.id);
            } else
            {
                if (string.Equals("apple", category, StringComparison.OrdinalIgnoreCase))
                {
                    phones = _allPhones.Phones.Where(i => i.Category.categoryName.Equals("IOS")).OrderBy(i => i.id);
                    currCategory = "iPhones";
                } else if (string.Equals("androids", category, StringComparison.OrdinalIgnoreCase))
                {
                    phones = _allPhones.Phones.Where(i => i.Category.categoryName.Equals("Android")).OrderBy(i => i.id);
                    currCategory = "Androids";
                } else if (string.Equals("windowsphones", category, StringComparison.OrdinalIgnoreCase))
                {
                    phones = _allPhones.Phones.Where(i => i.Category.categoryName.Equals("WindowsPhone")).OrderBy(i => i.id);
                    currCategory = "WindowsPhones";
                }
            }

            var phoneObj = new PhonesListViewModel
            {
                allPhones = phones,
                currCategory = currCategory
            };
            ViewBag.Title = "Страница с телефонами";

            return View(phoneObj);
        }
            

    }
} 
