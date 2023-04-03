using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.IO;

namespace OfflineRepoCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            for (int i = 0; i < 42; i++)
            {
                Console.Clear();
                Console.WriteLine($"Getting data {i}/42");
                var tempItems = GetItemsAsync("a", i).Result;
                foreach (var item in tempItems)
                {
                    items.Add(item);
                }
            }

            string json = JsonConvert.SerializeObject(items, Formatting.Indented);
            File.WriteAllText("items.json", json);
        }

        public static async Task<List<Item>> GetItemsAsync(string name, int category)
        {
            if (name == string.Empty)
            {
                name = "a";
            }
            List<Item> items = new List<Item>();
            string endpoint = $"https://secure.runescape.com/m=itemdb_rs/api/catalogue/items.json?category={category}&alpha={name}&page=1";
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
            return items;
        }
    }

}
