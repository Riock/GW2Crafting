using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2Crafting.Entities
{
    public class Recipe
    {
        public Item Output { get; set; }
        public List<Item> Input { get; set; }

        /// <summary>
        /// Calculates the total cost of this recipe.
        /// </summary>
        public int TotalCost
        {
            get
            {
                int ret = 0;
                foreach (Item i in this.Input)
                {
                    ret += i.Price;
                }
                return ret;
            }
        }

        public Recipe(Item output, List<Item> input)
        {
            this.Output = output;
            this.Input = input;
        }
    }
}
