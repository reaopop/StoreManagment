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
    public partial class frm_Invoices : InvoicesVM
    {
        #region Constractor
        public frm_Invoices(Master.InvoiceType type)
        {
            InitializeComponent();
            Type = type;
            newToolStripMenuItem.PerformClick();
        }
        public frm_Invoices(Master.InvoiceType type , int InvoiceID)
        {
            InitializeComponent();
            invoice = Database.InvoiceHeader.FirstOrDefault(x => x.ID == InvoiceID);
            invoiceDetails = Database.InvoiceDetails.Where(x => x.InvoiceID == InvoiceID).ToList();
            GetData();
            Type = type;
        }
        #endregion

        #region MainProperty
        Master.InvoiceType Type;
        #endregion

        #region Events


        private void frm_Invoices_Load(object sender, EventArgs e)
        {
            cmb_Items.SelectedIndexChanged += Cmb_Items_SelectedIndexChanged;
            txt_Total.TextChanged += Txt_Total_TextChanged;
            txt_Discount.TextChanged += Txt_Total_TextChanged;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            this.KeyDown += Frm_Invoices_KeyDown;
            dt_Qty.TextChanged += Dt_Qty_TextChanged;
            dt_Price.TextChanged += Dt_Qty_TextChanged;

            cmb_Items.Items.Clear();
            cmb_Items.Items.AddRange(Database.Products.ToArray());
            cmb_Items.DisplayMember = nameof(Product.Name);
            cmb_Items.ValueMember = nameof(Product.ID);
            dataGridView1.DataSource = invoiceDetails;
            

            txt_Total.ReadOnly = true;
            txt_Nat.ReadOnly = true;
            txt_InvoiceID.ReadOnly = true;
            dt_Total.ReadOnly = true;
            switch (Type)
            {
                case Master.InvoiceType.Sales:
                    this.Text = "Sales Invoice";
                    break;
                case Master.InvoiceType.Purchese:
                    this.Text = "Purchese Invoice";
                    break;
                default:
                    break;
            }
        }

        private void Frm_Invoices_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btn_AddToGrid.PerformClick();
               
            }
        }

        private void Dt_Qty_TextChanged(object sender, EventArgs e)
        {
            if (dt_Qty.Text.Trim() == string.Empty || dt_Price.Text.Trim() == string.Empty) return;
           dt_Total.Text = (Convert.ToDouble(dt_Qty.Text.Trim()) * Convert.ToDouble(dt_Price.Text.Trim())).ToString();
            Txt_Total_TextChanged(null, null);
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Txt_Total_TextChanged(null, null);
        }

        private void Txt_Total_TextChanged(object sender, EventArgs e)
        {
            var Data = dataGridView1.DataSource as List<InvoiceDetails>;
            if (Data == null) return;
            txt_Total.Text = Data.Sum(x => x.Total).ToString();
            txt_Nat.Text = (Convert.ToDouble(txt_Total.Text.Trim()) - Convert.ToDouble(txt_Discount.Text.Trim())).ToString();
            var ID = ((Product)cmb_Items.SelectedItem).ID;
            txt_Balance.Text = ((Database.InvoiceDetails.Where(x=> x.ItemID == ID &&  Database.InvoiceHeader.FirstOrDefault(z=>z.ID ==  x.InvoiceID).InvoiceType == (int)Master.InvoiceType.Purchese).Sum(x=> (double?)x.Qty)??0) - (Database.InvoiceDetails.Where(x => x.ItemID == ID && Database.InvoiceHeader.FirstOrDefault(z => z.ID == x.InvoiceID).InvoiceType == (int)Master.InvoiceType.Sales).Sum(x => (double?)x.Qty)??0)).ToString();
        }

        private void Cmb_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Items.SelectedItem == null) return;
            if (dt_Qty.Text == string.Empty)
                dt_Qty.Text = "1";
            Product pro = Database.Products.FirstOrDefault(x => x.ID == ((Product)cmb_Items.SelectedItem).ID);
            switch (Type)
            {
                case Master.InvoiceType.Sales:
                    dt_Price.Text = pro.SellPrice.ToString();
                    break;
                case Master.InvoiceType.Purchese:
                    dt_Price.Text = pro.BuyPrice.ToString();
                    break;
                default:
                    break;
            }
            
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetData();
            Add();
            newToolStripMenuItem.PerformClick();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        // If you need
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
            GetData();
        }
        private void btn_AddToGrid_Click(object sender, EventArgs e)
        {
            if (dt_Qty.Text.Trim() == string.Empty || dt_Price.Text.Trim() == string.Empty || cmb_Items.SelectedItem == null) { }
            else
            {
                InvoiceDetails inv = new InvoiceDetails();
                inv.ItemID = ((Product)cmb_Items.SelectedItem).ID;
                inv.Price = Convert.ToDouble(dt_Price.Text.Trim());
                inv.Qty = Convert.ToDouble(dt_Qty.Text.Trim());
                inv.Total = Convert.ToDouble(dt_Total.Text.Trim());
                invoiceDetails.Add(inv);
                dt_Total.Text = "0";
                dt_Price.Text = "0";
                dt_Qty.Text = "0";
                cmb_Items.SelectedIndex = 0;
                cmb_Items.Focus();
                cmb_Items.Select();
                cmb_Items.SelectAll();
                dataGridView1.DataSource = invoiceDetails.ToList();
                Txt_Total_TextChanged(null, null);
            }
        }

        private void btn_DeleteFromGrid_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                var Data = dataGridView1.DataSource as List<InvoiceDetails>;
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Data.Remove((InvoiceDetails)dataGridView1.SelectedRows[0].DataBoundItem);
                    dataGridView1.DataSource = Data.ToList();

                }
            }
        }

        private void btn_EditRowFromGrid_Click(object sender, EventArgs e)
        {

        }

        #endregion



        #region Helper
        void GetData()
        {
            dataGridView1.DataSource = invoiceDetails;
            txt_InvoiceID.Text = invoice.ID.ToString();
            txt_Discount.Text = invoice.Discount.ToString();
            txt_Nat.Text = invoice.Nat.ToString() ;
            txt_Total.Text = invoice.Total.ToString();
            dt_Date.Value = invoice.PostDate;
        }
        void SetData()
        {
            invoice.ID = Convert.ToInt32(txt_InvoiceID.Text.Trim());
            invoice.Discount = Convert.ToDouble(txt_Discount.Text.Trim());
            invoice.InvoiceType = (byte)Type;
            invoice.Nat = Convert.ToDouble(txt_Nat.Text.Trim());
            invoice.Total = Convert.ToDouble(txt_Total.Text.Trim()) ;
            invoice.PostDate = dt_Date.Value;

        }
        void ValidateInvoice()
        {

        }



        #endregion

       
    }
}
