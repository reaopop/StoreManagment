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
    public partial class frm_Home : Form
    {
        #region Constractor
        public frm_Home()
        {
            InitializeComponent();
            this.FormClosed += Frm_Home_FormClosed;
            treeView1.AfterSelect += TreeView1_TabIndexChanged;
            addCategoryToolStripMenuItem.Click += AddCategoryToolStripMenuItem_Click;
        }
        #endregion

        #region Events

        private void frm_Home_Load(object sender, EventArgs e)
        {
            AddNodes();
            this.Text = "Haupt Menu";

            usersToolStripMenuItem.CustomizingHome();

        }
        private void TreeView1_TabIndexChanged(object sender, EventArgs e)
        {
            var node = treeView1.SelectedNode;
            if (Database.Products.Where(x => x.Name == node.Text).Count() > 0)
            {
                var data = Database.Products.FirstOrDefault(x => x.Name == node.Text);
                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.Columns.Add("");
                listView1.Columns.Add(nameof(data.ID));
                listView1.Columns.Add("Name");
                listView1.Columns.Add("SellPrice");
                listView1.Columns.Add("BuyPrice");
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(data.ID.ToString());
                lvi.SubItems.Add(data.Name);
                lvi.SubItems.Add(data.SellPrice.ToString());
                lvi.SubItems.Add(data.BuyPrice.ToString());
                listView1.Items.Add(lvi);
            }
        }
        private void Frm_Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_AccessUsers().Show();
        }
        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_AddProducts().Show();
        }
        private void AddCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_AddCategories().Show();
        }
        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNodes();
        }
        private void فاتورةجديديةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Invoices(Master.InvoiceType.Sales).Show();

        }
        private void قائمةالفواتيرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_InvoicesList(Master.InvoiceType.Sales).Show();
        }
        private void فاتورةجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Invoices(Master.InvoiceType.Purchese).Show();

        }
        private void قائمةالفواتيرToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frm_InvoicesList(Master.InvoiceType.Purchese).Show();

        }

        #endregion

        #region Property
        int Index = 0;

        #endregion

        #region Helper
        void AddNodes()
        {
            treeView1.Nodes.Clear();
            Index = 0;
            foreach (var item in Database.Units.Where(x => x.PerantID == 0))
            {
                AddData(item, null, null);
            }
        }
        void AddData(Unites item, TreeNodeCollection treenode, TreeNode node = null, int key = -1)
        {
            var Node = (node == null) ? new TreeNode() { Name = item.Name, Text = item.Name, ForeColor = Color.Red } : node;
            foreach (var pr in Database.Products.Where(x => x.UnitID == item.ID))
            {
                var proNode = new TreeNode() { Name = pr.Name, Text = Text = pr.Name, ForeColor = Color.Blue };
                Node.Nodes.Add(proNode);
            }
            var TreeNode = (treenode == null) ? treeView1.Nodes : treenode;
            if (!CheckIfExist(item.Name))
            {
                var ind = (key > -1) ? treeView1.Nodes[key].Nodes.Add(Node) : TreeNode.Add(Node);


                if (Database.Units.Where(x => x.PerantID == item.ID).Count() > 0)
                {
                    foreach (var q in Database.Units.Where(x => x.PerantID == item.ID))
                    {
                        AddData(q, TreeNode, new TreeNode() { Tag = q.Name, Name = q.Name, Text = q.Name, ForeColor = Color.Green }, Node.Index);

                    }
                }
                Index++;
            }
        }
        bool CheckIfExist(string text)
        {
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {
                if (treeView1.Nodes[i].Text == text) return true;
            }
            return false;
        }

        #endregion

    }
}
