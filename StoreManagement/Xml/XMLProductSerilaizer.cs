using StoreManagement.Model;
using StoreManagement.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StoreManagement.Xml
{

    interface IXMLProductSerilaizer
    {
        bool CreateOrUpdateProduct(Product user);
        bool DeleteProduct(Product user);
        List<Product> ReadProduct();

    }
    public class XMLProductSerilaizer : IXMLProductSerilaizer
    {
        public string connection { get => (Master.XMLPath + "Products.xml"); }
        public bool CreateOrUpdateProduct(Product user)
        {
            Database.Products.Add(user);
            return PostData();
        }
        bool PostData()
        {
            try
            {
                XMLProduct xml = new XMLProduct() { Products = Database.Products.ToList() };
                XmlSerializer serializer =
                new XmlSerializer(typeof(XMLProduct));
                TextWriter writer = new StreamWriter(connection, false, Encoding.UTF8);
                XMLProduct po = xml;

                serializer.Serialize(writer, po);
                writer.Flush
                    ();
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool DeleteProduct(Product user)
        {
            Database.Products.Remove(user);
            return PostData();
        }

        public List<Product> ReadProduct()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XMLProduct));
            FileStream fs = new FileStream(connection, FileMode.Open);
            XMLProduct dezerializedList = (XMLProduct)serializer.Deserialize(fs);
            return dezerializedList.Products;
        }
    }
}
