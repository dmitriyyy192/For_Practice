using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Repository
{
    public class PhoneRepository : IAllPhones
    {

        private readonly AppDBContent appDBContent;

        public PhoneRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Phone> Phones => appDBContent.Phone.Include(c => c.Category);

        public IEnumerable<Phone> getFavPhones => appDBContent.Phone.Where(p => p.isFavourite).Include(c => c.Category);

        public Phone getObjectPhone(int phoneId) => appDBContent.Phone.FirstOrDefault(p => p.id == phoneId);
    }
}
