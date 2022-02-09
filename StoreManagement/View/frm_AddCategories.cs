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
    public partial class frm_AddCategories : AddCategoriesVM
    {
        #region Constractor
        public frm_AddCategories()
        {
            InitializeComponent();
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            this.Load += frm_AddCategories_Load;
            New();
            GetData();
        }
        public frm_AddCategories(int ID)
        {
            InitializeComponent();
            uni = Database.Units.FirstOrDefault(x => x.ID == ID);
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
        private void frm_AddCategories_Load(object sender, EventArgs e)
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

            cmb_Unite.SelectedItem = Database.Units.FirstOrDefault(x => x.ID == Convert.ToInt32(row.Cells[0].Value));
            uni = Database.Units.FirstOrDefault(x => x.ID == Convert.ToInt32(row.Cells[0].Value));
        }
        #endregion

        #region Helper
        void SetData()
        {
            uni.ID = Convert.ToInt32(txt_ID.Text.Trim());
            uni.Name = txt_Name.Text.Trim();

            uni.PerantID = (((Unites)cmb_Unite.SelectedItem) == null) ? 0 : ((Unites)cmb_Unite.SelectedItem).ID;
        }
        void GetData()
        {
            txt_ID.Text = uni.ID.ToString();
            txt_Name.Text = uni.Name;

            cmb_Unite.SelectedValue = uni.PerantID;

            RefreshForm();
        }
        void RefreshForm()
        {
            cmb_Unite.Items.Clear();
            cmb_Unite.Items.AddRange(Database.Units.ToArray());
            cmb_Unite.DisplayMember = nameof(Unites.Name);
            cmb_Unite.ValueMember = nameof(Unites.ID);
            dataGridView1.DataSource = Database.Units.Select(x => new { x.ID, x.Name, x.PerantID }).ToList();
        }
        #endregion

    }
}
