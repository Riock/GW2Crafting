using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2Crafting.Entities
{
    public class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
        /// <summary>
        /// Used for recipies
        /// </summary>
        public int Quantity { get; set; }
        public Recipe Recipe { get; set; }

        public Item(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Price = -1;
        }
        public Item(int id, string name, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return this.Name + " <" + this.Id + ">";
        }
    }
}
