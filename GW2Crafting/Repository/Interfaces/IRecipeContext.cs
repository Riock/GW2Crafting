using GW2Crafting.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2Crafting.Repository.Interfaces
{
    public interface IRecipeContext
    {
        /// <summary>
        /// gets all recipes to make a specified item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        List<Recipe> GetRecipe(Item item);
    }
}
