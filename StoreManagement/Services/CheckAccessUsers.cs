using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Services
{
    public static class CheckAccessUsers
    {
        public static bool AddProduct { get { return (bool)Database.UserAccess.FirstOrDefault(x => x.UserID == Master.ThisUser.ID && x.AccessName == "Add Products").Value; } }
        public static bool DeleteProdcut { get { return (bool)Database.UserAccess.FirstOrDefault(x => x.UserID == Master.ThisUser.ID && x.AccessName == "Delete Products").Value; } }
    }
}
