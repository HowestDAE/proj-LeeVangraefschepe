using RunescapeItemSearcher.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunescapeItemSearcher.Repository
{
    public interface IItemRepository
    {
        List<Category> GetCategories();
        Task<List<Item>> GetItems(string name, Category category);
        string LastUpdate { get; }
    }
}
