using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunescapeItemSearcher.Model
{
    public class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public static List<Category> All { get; set; }
        public static List<Category> GetAll()
        {
            List<Category> list = new List<Category>();
            int id = 0;
            list.Add(new Category() { Id = id++, Name = "Miscellaneous" });
            list.Add(new Category() { Id = id++, Name = "Ammo" });
            list.Add(new Category() { Id = id++, Name = "Arrows" });
            list.Add(new Category() { Id = id++, Name = "Bolts" });
            list.Add(new Category() { Id = id++, Name = "Construction materials" });
            list.Add(new Category() { Id = id++, Name = "Construction products" });
            list.Add(new Category() { Id = id++, Name = "Cooking ingredients" });
            list.Add(new Category() { Id = id++, Name = "Costumes" });
            list.Add(new Category() { Id = id++, Name = "Crafting materials" });
            list.Add(new Category() { Id = id++, Name = "Familiars" });
            list.Add(new Category() { Id = id++, Name = "Farming produce" });
            list.Add(new Category() { Id = id++, Name = "Fletching materials" });
            list.Add(new Category() { Id = id++, Name = "Food and Drink" });
            list.Add(new Category() { Id = id++, Name = "Herblore materials" });
            list.Add(new Category() { Id = id++, Name = "Hunting equipment" });
            list.Add(new Category() { Id = id++, Name = "Hunting Produce" });
            list.Add(new Category() { Id = id++, Name = "Jewellery" });
            list.Add(new Category() { Id = id++, Name = "Mage armour" });
            list.Add(new Category() { Id = id++, Name = "Mage weapons" });
            list.Add(new Category() { Id = id++, Name = "Melee armour - low level" });
            list.Add(new Category() { Id = id++, Name = "Melee armour - mid level" });
            list.Add(new Category() { Id = id++, Name = "Melee armour - high level" });
            list.Add(new Category() { Id = id++, Name = "Melee weapons - low level" });
            list.Add(new Category() { Id = id++, Name = "Melee weapons - mid level" });
            list.Add(new Category() { Id = id++, Name = "Melee weapons - high level" });
            list.Add(new Category() { Id = id++, Name = "Mining and Smithing" });
            list.Add(new Category() { Id = id++, Name = "Potions" });
            list.Add(new Category() { Id = id++, Name = "Prayer armour" });
            list.Add(new Category() { Id = id++, Name = "Prayer materials" });
            list.Add(new Category() { Id = id++, Name = "Range armour" });
            list.Add(new Category() { Id = id++, Name = "Range weapons" });
            list.Add(new Category() { Id = id++, Name = "Runecrafting" });
            list.Add(new Category() { Id = id++, Name = "Runes, Spells and Teleports" });
            list.Add(new Category() { Id = id++, Name = "Seeds" });
            list.Add(new Category() { Id = id++, Name = "Summoning scrolls" });
            list.Add(new Category() { Id = id++, Name = "Tools and containers" });
            list.Add(new Category() { Id = id++, Name = "Woodcutting product" });
            list.Add(new Category() { Id = id++, Name = "Pocket items" });
            list.Add(new Category() { Id = id++, Name = "Stone spirits" });
            list.Add(new Category() { Id = id++, Name = "Salvage" });
            list.Add(new Category() { Id = id++, Name = "Firemaking products" });
            list.Add(new Category() { Id = id++, Name = "Archaeology materials" });
            return list;
        }
    }
}