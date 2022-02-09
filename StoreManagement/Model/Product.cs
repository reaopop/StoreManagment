using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StoreManagement.Model
{
    [Serializable, XmlRoot("Product")]

    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string descritption { get; set; }
        public int  quantity { get; set; }
        public double BuyPrice { get; set; } 
        public double SellPrice { get; set; }
        public int UnitID { get; set; }
        

    }
    [Serializable, XmlRoot("XMLProduct")]
    public class XMLProduct
    {
        public List<Product> Products { get; set; }
    }
}
