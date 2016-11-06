using GW2Crafting.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GW2Crafting.Entities;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;

namespace GW2Crafting.Repository.Data
{
    public class ItemDataContext : IItemContext
    {
        public List<Item> GetPrice(List<Item> items)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetAllFromCSV()
        {
            List<Item> ret = new List<Item>();
            using (StreamReader reader = new StreamReader(File.OpenRead("Items.csv")))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    var values = line.Split(',');
                    ret.Add(new Item(Convert.ToInt32(values[0]), values[1]));
                }
            }
            return ret;
        }

        public List<Item> SearchByName(string query)
        {
            List<Item> ret = new List<Item>();

            using (WebClient webclient = new WebClient())
            {
                string json = webclient.DownloadString("http://www.gw2spidy.com/api/v0.9/json/item-search/" + query);
                JObject jObject = JObject.Parse(json);
                JToken jResults = jObject["results"];
                foreach (var v in jResults)
                {
                    ret.Add(CreateItemFromJson(v));
                }
            }
            return ret;
        }

        private Item CreateItemFromJson(JToken json)
        {
            Item ret = new Item(
                (int)json["data_id"],
                (string)json["name"]
                );
            return ret;
        }

        public void AddToCSV(List<Item> items)
        {
            //read csv
            //compare names/id's in csv to new items
            //add if new
            List<Item> csv = GetAllFromCSV();
            foreach (Item i in items)
            {
                if (csv.Contains(i))
                {
                    items.Remove(i);
                }
            }

            using (StreamWriter file = new StreamWriter("Items.csv", true))
            {
                foreach (Item i in items)
                {
                    string write = i.Id + "," + i.Name;
                    file.WriteLine(write);
                }
            }
        }
    }
}
