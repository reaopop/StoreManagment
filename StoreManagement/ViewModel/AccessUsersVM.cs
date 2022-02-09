using StoreManagement.Model;
using StoreManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManagement.Xml;

namespace StoreManagement.ViewModel
{
    public class AccessUsersVM : Form, IFormMain
    {
        #region Properties
        public User user;
        public XMLAccessUserSerializer xmlAcc;
        public XMLUserSerilaizer xmlUser;
        #endregion

        #region Constractor
        public AccessUsersVM()
        {
            xmlAcc = new XMLAccessUserSerializer();
            xmlUser = new XMLUserSerilaizer();
        }
        #endregion

        #region Helper
        public void Add()
        {
            throw new NotImplementedException();
        }
        public void AddAccessUser(bool AddProduct, bool DeleteProduct, bool SellProduct)
        {
            var Data = Database.UserAccess.Where(x => x.UserID == Master.ThisUser.ID).ToList();
            foreach (var item in Data)
            {
                xmlAcc.DeleteInoviceDetails(item);
            }
            List<UserAccess> ulist = new List<UserAccess>()
            {
                new Model.UserAccess() { ID = 1, UserID = user.ID, AccessName = "Add Products", Value = AddProduct },
                new Model.UserAccess() { ID = 2, UserID = user.ID, AccessName = "Delete Products", Value = DeleteProduct },
                new Model.UserAccess() { ID = 3, UserID = user.ID, AccessName = "Sell Products", Value = SellProduct }
            };
            foreach (var item in ulist)
            {
                xmlAcc.CreateOrUpdateInvoiceDetails(item);
            }
            New();
            MessageBox.Show("It has been saved!!");
        }
        public void Delete()
        {
            throw new NotImplementedException();
        }
        public void New()
        {
            user = new User();
        }
        public void RefreshData()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
