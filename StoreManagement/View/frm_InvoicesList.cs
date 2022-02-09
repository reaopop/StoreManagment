using StoreManagement.Services;
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
    public partial class frm_InvoicesList : Form
    {
        #region Properties
        Master.InvoiceType Type;
        #endregion

        #region Constractor
        public frm_InvoicesList(Master.InvoiceType type)
        {
            InitializeComponent();
            Type = type;
        }
        #endregion

        #region Helper
        private void frm_InvoicesList_Load(object sender, EventArgs e)
        {
            dataGridView1.DoubleClick += DataGridView1_DoubleClick;
            RefreshData();

        }
        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            int invoiceID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            new frm_Invoices(Type, invoiceID).Show();
        }
        void RefreshData()
        {
            dataGridView1.DataSource = Database.InvoiceHeader.Where(x => x.InvoiceType == (int)Type).ToList();
        }
        #endregion
    }
}
