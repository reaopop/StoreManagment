using StoreManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.ViewModel
{
    public class LoginVM : Form, IFormMain
    {
        #region Constractor
        public LoginVM()
        {

        }
        #endregion

        #region MainProperty

        #endregion

        #region Helper
        public void Add()
        {
            throw new NotImplementedException();
        }
        public void Delete()
        {
            throw new NotImplementedException();
        }
        public void New()
        {
            throw new NotImplementedException();
        }
        public void RefreshData()
        {
            throw new NotImplementedException();
        }
        public bool Login(string UserName, string password)
        {
            var Result = Database.Users.Where(x => x.UserName == UserName && x.Password == password).Count();
            Master.ThisUser = Database.Users.FirstOrDefault(x => x.UserName == UserName && x.Password == password);
            return (Result > 0);
        }
        bool IFormMain.Validate()
        {
            return true;
        }
        #endregion
    }
}
