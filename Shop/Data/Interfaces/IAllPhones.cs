using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public interface IAllPhones
    {
        IEnumerable<Phone> Phones { get; }

        IEnumerable<Phone> getFavPhones { get; set; }
        Phone getObjectPhone(int phoneId);
    }
}
