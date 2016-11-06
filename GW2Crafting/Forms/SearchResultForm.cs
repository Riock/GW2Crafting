using GW2Crafting.Entities;
using GW2Crafting.Repository.Logic;
using GW2Crafting.Repository.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GW2Crafting.Forms
{
    public partial class SearchResultForm : Form
    {
        private ItemRepository itemRepo;

        private string query;
        private List<Item> items;

        public SearchResultForm(string query)
        {
            InitializeComponent();
            this.itemRepo = new ItemRepository(new ItemDataContext());

            this.query = query;
            this.Text = "Searching for: " + query;

            items = itemRepo.SearchByName(query);

            foreach (Item i in items)
            {
                lbResult.Items.Add(i.ToString());
            }
        }

        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            List<Item> ret = new List<Item>();
            foreach (object obj in lbResult.SelectedItems)
            {
                string search = lbResult.GetItemText(obj);
                foreach (Item i in this.items)
                {
                    if (search == i.ToString())
                    {
                        ret.Add(i);
                        break;
                    }
                }
            }
            itemRepo.AddToCSV(ret);
        }
    }
}
