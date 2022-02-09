using StoreManagement.Model;
using StoreManagement.Services;
using StoreManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.View
{
    public partial class frm_AddProducts : AddProductVM
    {
        #region Constractor
        public frm_AddProducts()
        {
            InitializeComponent();
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;

        }
        public frm_AddProducts(int ID)
        {
            InitializeComponent();
            Pro = Database.Products.FirstOrDefault(x => x.ID == ID);
            GetData();
        }
        #endregion

        #region Events
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetData();
            Add();
            newToolStripMenuItem.PerformClick();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
            GetData();
            RefreshForm();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
            newToolStripMenuItem.PerformClick();
        }
        private void frm_AddProducts_Load(object sender, EventArgs e)
        {

            txt_ID.ReadOnly = true;
            New();
            GetData();
            RefreshForm();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];

            txt_ID.Text = row.Cells[0].Value.ToString();
            txt_Name.Text = row.Cells[1].Value.ToString();
            txt_BuyPrice.Text = row.Cells[2].Value.ToString();
            txt_SellPrice.Text = row.Cells[3].Value.ToString();
            txt_Quantity.Text = row.Cells[4].Value.ToString();
            cmb_Unite.SelectedItem = Database.Units.FirstOrDefault(x => x.ID == Convert.ToInt32(row.Cells[5].Value));
            Pro = Database.Products.FirstOrDefault(x => x.ID == Convert.ToInt32(row.Cells[0].Value));
        }
        #endregion

        #region Helper
        void SetData()
        {
            Pro.ID = Convert.ToInt32(txt_ID.Text.Trim());
            Pro.Name = txt_Name.Text.Trim();
            Pro.BuyPrice = Convert.ToDouble(txt_BuyPrice.Text.Trim());
            Pro.SellPrice = Convert.ToDouble(txt_SellPrice.Text.Trim());
            Pro.quantity = Convert.ToInt32(txt_Quantity.Text.Trim());
            Pro.UnitID = ((Unites)cmb_Unite.SelectedItem).ID;
            Pro.descritption = "";
        }
        void GetData()
        {
            txt_ID.Text = Pro.ID.ToString();
            txt_Name.Text = Pro.Name;
            txt_Quantity.Text = Pro.quantity.ToString();
            txt_BuyPrice.Text = Pro.BuyPrice.ToString();
            txt_SellPrice.Text = Pro.SellPrice.ToString();
            cmb_Unite.SelectedValue = Pro.UnitID;

            RefreshForm();
        }
        void RefreshForm()
        {
            cmb_Unite.Items.Clear();
            cmb_Unite.Items.AddRange(Database.Units.ToArray());
            cmb_Unite.DisplayMember = nameof(Unites.Name);
            cmb_Unite.ValueMember = nameof(Unites.ID);
            dataGridView1.DataSource = Database.Products.Select(x => new { x.ID, x.Name, x.BuyPrice, x.SellPrice, x.quantity, x.UnitID }).ToList();
        }
        #endregion

    }
}
