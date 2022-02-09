using StoreManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Services
{
    public static class Session
    {
        private static BindingList<UserAccess> _UserAccesses;
        public static BindingList<UserAccess> UserAccesses { get 
        {
                if(_UserAccesses == null)
                    _UserAccesses = new BindingList<UserAccess>(Database.UserAccess.Where(x => x.UserID == Master.ThisUser.ID).ToList());
                return _UserAccesses
        ;
            } }
    }
}
