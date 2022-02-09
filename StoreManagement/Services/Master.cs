using StoreManagement.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Services
{
    public static class Master
    {
        #region MainProperty
        public static string XMLPath { get=>(Directory.GetCurrentDirectory() +"\\XML");}
        public static User ThisUser { get; set; }
        #endregion

        #region Enums
        public enum UserType
        {
            Admin = 1,
            User,
        }
        public enum Actions
        {
            Show = 1,
            Open,
            Add,
            Edit,
            Delete,
            Print
        }
        public enum InvoiceType
        {
            Sales = 1, // sales 
            Purchese,  // Purchase 
        }
        #endregion

        #region Helper
        public static void CustomizingHome(this ToolStripItem bs)
        {
            if (Master.ThisUser.UserType != (int)Master.UserType.Admin) bs.Visible = false;
        }
        public static bool ValidateString(this TextBox txt)
        {
            if (txt.Text == string.Empty) return false;
            else return true;
        } 
        public static void ChangeDatagridViewOption(this DataGridView dt)
        {
            //foreach (var item in dt.SelectedRows)
            //{
            //    item
            //}
            
        }
        public static T FromByteArray<T>(byte[] data)
        {
            if (data == null)
                return default(T);
            BinaryFormatter binary = new BinaryFormatter();
            using (var Stream = new MemoryStream(data))
            {
                return (T)binary.Deserialize(Stream);
            }
        }
        public static byte[] ToByteArray<T>(T obj)
        {
            if (obj == null) return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        //public static byte[] GetPropertyValue(string PropertyName, int profileID)
        //{
            
        //        var prop = Database.UserAccess.FirstOrDefault(x => x.UserID == profileID && x.AccessName == PropertyName);
        //        if (prop == null) return null;
        //        return (byte[])prop.Value;
        //}
        //public static byte[] GetPropertyValue(string PropertyName)
        //{
          
        //        var prop = Database.UserAccess.FirstOrDefault(x => x.AccessName == PropertyName);
        //        if (prop == null) return null;
        //        return (byte[])prop.Value;
        //}

        public static string GetNameProperty([CallerMemberName] string NameProperty = "")
        {
            return NameProperty;
        }
        #endregion
        }
}
