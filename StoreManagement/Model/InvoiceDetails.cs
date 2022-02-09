using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StoreManagement.Model
{
    [Serializable, XmlRoot("InvoiceDetails")]

    public class InvoiceDetails
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public double Qty { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public int InvoiceID { get; set; }
    }
    [Serializable, XmlRoot("XMLInvoiceDetails")]
    public class XMLInvoiceDetails
    {
        public List<InvoiceDetails> Inovices { get; set; }
    }
}
