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
    public class AddProductVM : Form, IFormMain
    {
        #region Constractor
        public AddProductVM()
        {
            xmlSer = new XMLProductSerilaizer();
        }
        #endregion

        #region MainProperty
        public Product Pro { get; set; }
        public XMLProductSerilaizer xmlSer;
        #endregion

        #region Helper
        public void Add()
        {
            bool Result = false;
            if (Pro.ID == 0)
            {
                if (Database.UserAccess.Where(x => x.UserID == Master.ThisUser.ID && x.AccessName == "Add Products" && (bool)x.Value == true).Count() > 0)
                {
                    Pro.ID = (Database.Products.Max(x => (int?)x.ID) ?? 0) + 1;
                    xmlSer.CreateOrUpdateProduct(Pro);
                    //Database.Products.Add(Pro);
                    Result = true;
                }
                else MessageBox.Show("You are not authorized person to add products");
            }
            else
            {
                var pr = Database.Products.FirstOrDefault(x => x.ID == Pro.ID);
                xmlSer.DeleteProduct(pr);
                xmlSer.CreateOrUpdateProduct(Pro);
                //Database.Products[index].Name = Pro.Name;
                //Database.Products[index].quantity = Pro.quantity;
                //Database.Products[index].BuyPrice = Pro.BuyPrice;
                //Database.Products[index].SellPrice = Pro.SellPrice;
                //Database.Products[index].UnitID = Pro.UnitID;
                Result = true;
            }
            if (Result)
            {
                New();
                MessageBox.Show("It has been Succssfuly saved!");
            }

        }
        public void Delete()
        {
            if (MessageBox.Show(text: "Catogorie will be deleted!......Do you want to countiue?", caption: "Delete", icon: MessageBoxIcon.Question, buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Database.UserAccess.Where(x => x.UserID == Master.ThisUser.ID && x.AccessName == "Delete Products" && (bool)x.Value == true).Count() > 0)
                {
                    //Database.Products.Remove(Pro);
                    xmlSer.DeleteProduct(Pro);
                    MessageBox.Show("It has been succssfuly deleted!");

                }
                else MessageBox.Show("Sorry dont have athoriyation for deleting ");

            }
        }
        public void New()
        {
            Pro = new Product() { };
        }
        public void RefreshData()
        {
            throw new NotImplementedException();
        }
        bool ValidateData()
        {
            int Exceptions = 0;
            return true;
        }
        #endregion
    }
}
