using StoreManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.ViewModel
{
    public class HomeVM:Form,IFormMain
    {
        #region Constractor
        public HomeVM()
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

        bool IFormMain.Validate()
        {
            return true;
        }
        #endregion
    }
}
