﻿using System;
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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void btnItemList_Click(object sender, EventArgs e)
        {
            ItemListForm itemListForm = new ItemListForm();
            itemListForm.Show();
        }
    }
}
