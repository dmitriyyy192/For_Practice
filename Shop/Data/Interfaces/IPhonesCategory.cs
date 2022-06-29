using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Interfaces
{
    public interface IPhonesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
