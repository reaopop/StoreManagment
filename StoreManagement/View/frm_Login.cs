using StoreManagement.Services;
using StoreManagement.ViewModel;
using StoreManagement.Xml;
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
    public partial class frm_Login : LoginVM
    {
        #region Constractor
        public frm_Login()
        {
            InitializeComponent();
            //FillData();
        }
        #endregion

        #region Helper
        void FillData()
        {
            XMLAccessUserSerializer acc = new XMLAccessUserSerializer();
            XMLProductSerilaizer pro = new XMLProductSerilaizer();
            XMLUnitesSerializer uni = new XMLUnitesSerializer();
            XMLUserSerilaizer usr = new XMLUserSerilaizer();
            foreach (var item in Database.UserAccess.ToList())
            {
                acc.CreateOrUpdateInvoiceDetails(item);
            }
            foreach (var item in Database.Products.ToList())
            {
                pro.CreateOrUpdateProduct(item);
            }
            foreach (var item in Database.Units.ToList())
            {
                uni.CreateOrUpdateUnite(item);
            }
            foreach (var item in Database.Users.ToList())
            {
                usr.CreateOrUpdateUser(item);
            }
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            LoginMethod();
        }
        void LoginMethod(bool IsAdmin = false)
        {
            if (txt_UserName.ValidateString() || txt_Password.ValidateString())
            {
                var LoginResult = Login(txt_UserName.Text.Trim(), txt_Password.Text.Trim());
                if (LoginResult == true)
                {

                    MessageBox.Show("Whelcome " + Master.ThisUser.FullName);
                    new frm_Home().Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Username or Password is incorrect !!");
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_Admin_Click(object sender, EventArgs e)
        {
            new frm_AboutMe().Show();
        }
        #endregion
    }
}
