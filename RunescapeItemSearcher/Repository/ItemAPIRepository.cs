using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RunescapeItemSearcher.Model;

namespace RunescapeItemSearcher.Repository
{
    public class ItemAPIRepository
    {
        public async Task<List<Item>> GetItems(string name)
        {
            if (name == string.Empty)
            {
                name = "a";
            }
            List<Item> items = new List<Item>();
            for (int i = 0; i < 42; ++i)
            {
                string endpoint = $"https://secure.runescape.com/m=itemdb_rs/api/catalogue/items.json?category={i}&alpha={name}&page=1";
                string json = string.Empty;
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(endpoint);
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new HttpRequestException(response.ReasonPhrase);
                    }
                    json = await response.Content.ReadAsStringAsync();
                }

                var cardTokens = JToken.Parse(json).SelectToken("items");
                foreach (var token in cardTokens)
                {
                    var item = token.ToObject<Item>();
                    items.Add(item);
                }
            }

            return items;
        }
    }
}
