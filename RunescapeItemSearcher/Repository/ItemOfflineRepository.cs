using Newtonsoft.Json.Linq;
using RunescapeItemSearcher.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RunescapeItemSearcher.Repository
{
    public class ItemOfflineRepository : IItemRepository
    {
        private Dictionary<int, List<Item>> _data = null;
        private DateTime _lastUpdate = DateTime.MinValue;

        public string LastUpdate => GetLastUpdate();
        private string GetLastUpdate()
        {
            if (_lastUpdate == DateTime.MinValue)
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "RunescapeItemSearcher.Resources.Data.items.json";
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        string json = reader.ReadToEndAsync().Result;
                        var cardTokens = JToken.Parse(json).SelectToken("LastUpdate");
                        _lastUpdate = cardTokens.ToObject<DateTime>();
                    }
                }
            }
            return _lastUpdate.ToString("dd/MM/yyyy");
        }

        public List<Category> GetCategories()
        {
            return Category.GetAll();
        }

        public async Task<List<Item>> GetItems(string name, Category category)
        {
            if (_data == null)
            {
                await GetAllItems();
            }
            return _data[category.Id];
        }

        private async Task GetAllItems()
        {
            _data = new Dictionary<int, List<Item>>();
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "RunescapeItemSearcher.Resources.Data.items.json";
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (var reader = new StreamReader(stream))
                {
                    string json = await reader.ReadToEndAsync();
                    var cardTokens = JToken.Parse(json).SelectToken("Items");

                    foreach (var token in cardTokens)
                    {
                        var item = token.ToObject<Item>();
                        int id = Category.NameToId(item.Type);
                        if (!_data.ContainsKey(id))
                        {
                            _data.Add(id, new List<Item>());
                        }
                        _data[id].Add(item);
                    }
                }
            }
        }
    }
}
