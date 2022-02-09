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
    interface IXMLInvoiceHeaderSerializer
    {
        bool CreateOrUpdateInvoiceHeader(InvoiceHeader inv);
        bool DeleteInoviceHeader(InvoiceHeader inv);
        List<InvoiceHeader> ReadInvoiceHeader();

    }
    public class XMLInvoiceHeaderSerializer : IXMLInvoiceHeaderSerializer
    {
        public string connection { get => (Master.XMLPath + "InvoiceHeader.xml"); }
        bool PostData()
        {
            try
            {
                XMLInvoiceHeader xml = new XMLInvoiceHeader() { Inovices = Database.InvoiceHeader.ToList() };
                XmlSerializer serializer =
                new XmlSerializer(typeof(XMLInvoiceHeader));
                TextWriter writer = new StreamWriter(connection, false, Encoding.UTF8);
                XMLInvoiceHeader po = xml;

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
        


        public bool CreateOrUpdateInvoiceHeader(InvoiceHeader inv)
        {
            Database.InvoiceHeader.Add(inv);
            return PostData();
        }

        public bool DeleteInoviceHeader(InvoiceHeader inv)
        {
            Database.InvoiceHeader.Remove(inv);
            return PostData();
        }

        public List<InvoiceHeader> ReadInvoiceHeader()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(XMLInvoiceHeader));
                FileStream fs = new FileStream(connection, FileMode.OpenOrCreate);
                XMLInvoiceHeader dezerializedList = (XMLInvoiceHeader)serializer.Deserialize(fs);
                return dezerializedList.Inovices;
            }
            catch (Exception)
            {

                return new List<InvoiceHeader>();
            }
          
        }
    }
}
