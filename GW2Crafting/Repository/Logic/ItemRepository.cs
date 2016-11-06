using GW2Crafting.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GW2Crafting.Entities;

namespace GW2Crafting.Repository.Logic
{
    public class ItemRepository :IItemContext
    {
        private IItemContext context;

        public ItemRepository(IItemContext context)
        {
            this.context = context;
        }

        public List<Item> GetPrice(List<Item> items)
        {
            return context.GetPrice(items);
        }

        public List<Item> GetAllFromCSV()
        {
            return context.GetAllFromCSV();
        }

        public List<Item> SearchByName(string query)
        {
            return context.SearchByName(query);
        }

        public void AddToCSV(List<Item> items)
        {
            context.AddToCSV(items);
        }
    }
}
