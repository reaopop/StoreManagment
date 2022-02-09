using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace StoreManagement.Model
{
    [Serializable, XmlRoot("InvoiceHeader")]
    public class InvoiceHeader
    {
        public int ID { get; set; }
        public byte InvoiceType { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
        public double Nat { get; set; }
        public DateTime PostDate { get; set; }

    }
    [Serializable, XmlRoot("XMLInvoiceHeader")]
    public class XMLInvoiceHeader
    {
        public List<InvoiceHeader> Inovices { get; set; }
    }
}
