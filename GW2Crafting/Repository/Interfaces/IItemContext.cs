using GW2Crafting.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2Crafting.Repository.Interfaces
{
    public interface IItemContext
    {
        /// <summary>
        /// Gets all the items stored in the csv in a list
        /// </summary>
        /// <returns></returns>
        List<Item> GetAllFromCSV();

        /// <summary>
        /// Fills the price of items from the web api
        /// </summary>
        /// <returns></returns>
        List<Item> GetPrice(List<Item> items);

        /// <summary>
        /// Searches the web database for the items related to the search query
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        List<Item> SearchByName(string query);

        void AddToCSV(List<Item> items);
    }
}
