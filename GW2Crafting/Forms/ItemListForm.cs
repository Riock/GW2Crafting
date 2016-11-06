using GW2Crafting.Entities;
using GW2Crafting.Repository.Data;
using GW2Crafting.Repository.Interfaces;
using GW2Crafting.Repository.Logic;
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
    public partial class ItemListForm : Form
    {
        private ItemRepository itemRepo;

        private List<Item> Items;

        public ItemListForm()
        {
            InitializeComponent();
            itemRepo = new ItemRepository(new ItemDataContext());

            refreshForm();
        }

        private void lbAllItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = lbAllItems.GetItemText(lbAllItems.SelectedItem);
            Item ret = null;
            foreach (Item i in this.Items)
            {
                if (search == i.Name)
                {
                    ret = i;
                    break;
                }
            }

            lblItemName.Text = "Name: " + ret.Name;
            lblId.Text = "Id: " + Convert.ToString(ret.Id);
            if (ret.Price == -1)
            {
                lblPrice.Text = "Price unknown";
            }
            else
            {
                lblPrice.Text = "Price: " + Convert.ToString(ret.Price);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                MessageBox.Show("You cannot search with an empty query");
            }
            else
            {
                SearchResultForm searchResultForm = new SearchResultForm(tbSearch.Text);
                searchResultForm.ShowDialog();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void refreshForm()
        {
            Items = itemRepo.GetAllFromCSV();
            Items.Sort((p, q) => p.Name.CompareTo(q.Name));

            lbAllItems.Items.Clear();
            foreach (Item i in this.Items)
            {
                lbAllItems.Items.Add(i.Name);
            }
        }
    }
}
