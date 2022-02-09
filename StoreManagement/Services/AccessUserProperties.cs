using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Services
{
    public class AccessUserProperties
    {
        public ProductsSettings prosetings;
        public AccessUserProperties()
        {
            prosetings = new ProductsSettings();
        }

        //public static Control AddControle(string  PropertyName , object PropertyValue)
        //{
        //    AccessUserProperties ls;
        //    ButtonBase Edit = null;
        //    switch (PropertyName)
        //    {
        //        case nameof(ls.prosetings.DeleteProduct):
        //        case nameof(ls.prosetings.AddProducts):
        //            Edit =  new CheckBox();
        //            ((CheckBox)Edit).Checked = (bool)PropertyValue;
        //            break;
        //        default:
        //            break;
        //    }
        //    if (Edit != null)
        //    {
        //        Edit.Name = PropertyName;
        //        //Edit. = PropertyValue.ToString();
        //    }
        //    return Edit;

        //}

        public class ProductsSettings
        {
            public ProductsSettings()
            {
            }
            //public bool AddProducts { get { return Master.FromByteArray<bool>(Master.GetPropertyValue(Master.GetNameProperty())); } }
            //public bool DeleteProduct { get { return Master.FromByteArray<bool>(Master.GetPropertyValue(Master.GetNameProperty())); } }
        }

    }
}
