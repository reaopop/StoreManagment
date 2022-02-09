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
    public class AddCategoriesVM : Form, IFormMain
    {
        #region Constractor

        public AddCategoriesVM()
        {
            xmlUni = new XMLUnitesSerializer();
        }
        #endregion

        #region MainProperty

        public Unites uni { get; set; }
        XMLUnitesSerializer xmlUni;
        #endregion

        #region Helper
        public void Add()
        {
            if (uni.ID == 0)
            {
                uni.ID = (Database.Units.Max(x => (int?)x.ID)??0) + 1;
                xmlUni.CreateOrUpdateUnite(uni);
                //Database.Units.Add(uni);
            }
            else
            {
                var Un = Database.Units.FirstOrDefault(x => x.ID == uni.ID);
                xmlUni.DeleteUnite(Un);
                xmlUni.CreateOrUpdateUnite(uni);
                //Database.Units[index].Name = uni.Name;
                //Database.Units[index].PerantID = uni.PerantID;
                
            }
            New();
            MessageBox.Show("It has been saved!!");
        }

        public void Delete()
        {
            if (MessageBox.Show(text: "It will be deleted!!....Do You want to continue?", caption: "Delete", icon: MessageBoxIcon.Question, buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ValidateData())
                {
                    //Database.Units.Remove(uni);
                    xmlUni.DeleteUnite(uni);
                    MessageBox.Show("It has successfully deleted!");
                }
                else 
                    MessageBox.Show("It cannot be deleted Becuase it connected to other Products!");

            }
        }

        public void New()
        {
            uni = new Unites() { };
        }

        public void RefreshData()
        {
            throw new NotImplementedException();
        }
        bool ValidateData()
        {
            if (Database.Products.Where(x => x.UnitID == uni.ID).Count() > 0 || Database.Units.Where(x => x.PerantID == uni.ID).Count() > 0) return false;
            else return true;
        }

        #endregion
    }
}
