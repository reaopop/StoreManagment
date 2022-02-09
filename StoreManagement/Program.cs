using StoreManagement.View;
using StoreManagement.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManagement.Xml;
using StoreManagement.Services;

namespace StoreManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Login());
            //new XMLUserSerilaizer().CreateOrUpdateUser(new Model.User() {ID = 4,FullName = "Test",UserName="TT",Password="dd",IsActive=true,UserType = 1 });
            //var data = new XMLUserSerilaizer().ReadUsers();
           
        }

        
    }
}
