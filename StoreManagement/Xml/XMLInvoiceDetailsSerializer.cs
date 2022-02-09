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
    interface IXMLInvoiceDetailsSerializer
    {
        bool CreateOrUpdateInvoiceDetails(InvoiceDetails inv);
        bool DeleteInoviceDetails(InvoiceDetails inv);
        List<InvoiceDetails> ReadInvoiceDetails();

    }
    public class XMLInvoiceDetailsSerializer : IXMLInvoiceDetailsSerializer
    {
        public string connection { get => (Master.XMLPath + "InvoiceDetails.xml"); }
        bool PostData()
        {
            try
            {
                XMLInvoiceDetails xml = new XMLInvoiceDetails() { Inovices = Database.InvoiceDetails.ToList() };
                XmlSerializer serializer =
                new XmlSerializer(typeof(XMLInvoiceDetails));
                TextWriter writer = new StreamWriter(connection, false, Encoding.UTF8);
                XMLInvoiceDetails po = xml;

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


        public bool CreateOrUpdateInvoiceDetails(InvoiceDetails inv)
        {
            Database.InvoiceDetails.Add(inv);
            return PostData();
        }

        public bool DeleteInoviceDetails(InvoiceDetails inv)
        {
            Database.InvoiceDetails.Remove(inv);
            return PostData();
        }

        public List<InvoiceDetails> ReadInvoiceDetails()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(XMLInvoiceDetails));
                FileStream fs = new FileStream(connection, FileMode.OpenOrCreate);
                XMLInvoiceDetails dezerializedList = (XMLInvoiceDetails)serializer.Deserialize(fs);
                return dezerializedList.Inovices;
            }
            catch (Exception)
            {
                return new List<InvoiceDetails>();
            }

           
        }
    }
}
