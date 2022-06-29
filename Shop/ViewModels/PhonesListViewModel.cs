using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.ViewModels
{
    public class PhonesListViewModel
    {
        public IEnumerable<Phone> allPhones { get; set; }
        public string currCategory { get; set; }
    }
}
