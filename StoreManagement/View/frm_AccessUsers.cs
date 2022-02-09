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
    public partial class frm_AccessUsers : AccessUsersVM
    {
        public frm_AccessUsers()
        {
            InitializeComponent();
            user = Master.ThisUser;
            GetData();
            dataGridView1.DataSource = Database.Users.Select(x => new { x.ID,x.FullName,x.UserName,x.UserType}).ToList();
            dataGridView1.DoubleClick += DataGridView1_DoubleClick;
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];
            user = Database.Users.FirstOrDefault(x => x.ID == Convert.ToInt32(row.Cells[0].Value));
            GetData();
        }

        private void GetData()
        {
            chk_AddProducts.Checked = (Database.UserAccess.FirstOrDefault(x => x.UserID == user.ID && x.AccessName == "Add Products") != null)?Database.UserAccess.FirstOrDefault(x => x.UserID == user.ID && x.AccessName == "Add Products").Value:false;
            chk_deleteProducts.Checked = (Database.UserAccess.FirstOrDefault(x => x.UserID == user.ID && x.AccessName == "Delete Products") != null)?Database.UserAccess.FirstOrDefault(x => x.UserID == user.ID && x.AccessName == "Delete Products").Value:false;
            chk_SellProducts.Checked = (Database.UserAccess.FirstOrDefault(x => x.UserID == user.ID && x.AccessName == "Sell Products") != null)?Database.UserAccess.FirstOrDefault(x => x.UserID == user.ID && x.AccessName == "Sell Products").Value:false;
            
            txt_UserName.Text = user.FullName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccessUser(chk_AddProducts.Checked, chk_deleteProducts.Checked,chk_SellProducts.Checked);

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Database.UserAccess.Where(x => x.UserID == Master.ThisUser.ID && x.AccessName == "Sell Products" && (bool)x.Value == true).Count() > 0)
            {
                MessageBox.Show("Done >>>");
            }
            else MessageBox.Show("ليس لديك صلاحية أضافة صنف");
        }
    }
    
}
