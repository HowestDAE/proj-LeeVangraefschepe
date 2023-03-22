using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunescapeItemSearcher.Model
{
    public class Item
    {
        [JsonProperty (propertyName: "id")]
        public int Id { get; set; }
        [JsonProperty (propertyName: "name")]
        public string Name { get; set; }
        [JsonProperty(propertyName: "icon")]
        public string Icon { get; set; }
        [JsonProperty (propertyName: "description")]
        public string Description { get; set; }
        [JsonProperty(propertyName: "current")]
        public Current Current { get; set; }
    }
    public class Current
    {
        [JsonProperty (propertyName: "price")]
        public string price { get; set; }
    }
}
