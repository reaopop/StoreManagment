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
    public class InvoicesVM : Form, IFormMain
    {
        #region Constractor
        public InvoicesVM()
        {
            XmlInvoice = new XMLInvoiceHeaderSerializer();
            XmlInvoiceDetails = new XMLInvoiceDetailsSerializer();
            XmlPro = new XMLProductSerilaizer();
        }
        #endregion

        #region MainProperty
        public InvoiceHeader invoice;
        public List<InvoiceDetails> invoiceDetails;
        public XMLInvoiceHeaderSerializer XmlInvoice;
        public XMLInvoiceDetailsSerializer XmlInvoiceDetails;
        public XMLProductSerilaizer XmlPro;

        #endregion

        #region Helper
        public void Add()
        {
            if (ValidateData())
            {
                bool Result = false;
                if (invoice.ID == 0)
                {
                    invoice.ID = (Database.InvoiceHeader.Max(x => (int?)x.ID) ?? 0) + 1;
                    XmlInvoice.CreateOrUpdateInvoiceHeader(invoice);
                    foreach (var item in invoiceDetails)
                    {
                        item.InvoiceID = invoice.ID;
                        item.ID = (Database.InvoiceDetails.Max(x => (int?)x.ID) ?? 0) + 1;
                        XmlInvoiceDetails.CreateOrUpdateInvoiceDetails(item);
                    }
                    Result = true;
                }
                else
                {
                    var header = Database.InvoiceHeader.FirstOrDefault(x => x.ID == invoice.ID);
                    XmlInvoice.DeleteInoviceHeader(header);
                    XmlInvoice.CreateOrUpdateInvoiceHeader(header);
                    foreach (var item in Database.InvoiceDetails.Where(x => x.InvoiceID == invoice.ID).ToList())
                    {
                        var dd = Database.Products.IndexOf(Database.Products.FirstOrDefault(x => x.ID == item.ItemID));
                        Database.Products[dd].quantity -= Convert.ToInt32(item.Qty);
                        Database.InvoiceDetails.Remove(item);
                    }
                    foreach (var item in invoiceDetails)
                    {
                        item.InvoiceID = invoice.ID;
                        item.ID = (Database.InvoiceDetails.Max(x => (int?)x.ID) ?? 0) + 1;
                        XmlInvoiceDetails.CreateOrUpdateInvoiceDetails(item);

                    }
                    Result = true;
                }
                if (Result)
                {
                    New();
                    MessageBox.Show("تم الحفظ بنجاح");
                }
            }
            else
                MessageBox.Show("يجب ان يحتوي الجدول علي الاصناف");

        }
        public void Delete()
        {
            if (invoice.ID != 0 && MessageBox.Show(text: "سيتم حذف الفاتورة......هل تريد المتابعة", caption: "حذف", icon: MessageBoxIcon.Question, buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (var item in Database.InvoiceDetails.Where(x => x.InvoiceID == invoice.ID).ToList())
                {

                    var dd = Database.Products.FirstOrDefault(x => x.ID == item.ItemID);
                    XmlPro.DeleteProduct(dd);
                    dd.quantity = dd.quantity - Convert.ToInt32(item.Qty);
                    XmlPro.CreateOrUpdateProduct(dd);
                    XmlInvoiceDetails.DeleteInoviceDetails(item);
                }
                XmlInvoice.DeleteInoviceHeader(invoice);
                MessageBox.Show("تم الحذف بنجاح");


            }
        }
        public void New()
        {
            invoice = new InvoiceHeader() { PostDate = DateTime.Now };
            invoiceDetails = new List<InvoiceDetails>();
        }
        public void RefreshData()
        {
            throw new NotImplementedException();
        }
        public bool ValidateData()
        {
            return (invoiceDetails.Count > 0);
        }
        #endregion

    }
}
