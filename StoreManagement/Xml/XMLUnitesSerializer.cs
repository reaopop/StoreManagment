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

    interface IXMLUnitesSerializer
    {
        bool CreateOrUpdateUnite(Unites uni);
        bool DeleteUnite(Unites uni);
        List<Unites> ReadUnite();

    }
    public class XMLUnitesSerializer : IXMLUnitesSerializer
    {
        public string connection { get => (Master.XMLPath + "Unites.xml"); }
        bool PostData()
        {
            try
            {
                XMLUnite xml = new XMLUnite() { unites = Database.Units.ToList() };
                XmlSerializer serializer =
                new XmlSerializer(typeof(XMLUnite));
                TextWriter writer = new StreamWriter(connection, false, Encoding.UTF8);
                XMLUnite po = xml;

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
        public bool CreateOrUpdateUnite(Unites uni)
        {
            Database.Units.Add(uni);
            return PostData();
        }

        public bool DeleteUnite(Unites uni)
        {
            Database.Units.Remove(uni);
            return PostData();
        }

        public List<Unites> ReadUnite()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XMLUnite));
            FileStream fs = new FileStream(connection, FileMode.Open);
            XMLUnite dezerializedList = (XMLUnite)serializer.Deserialize(fs);
            return dezerializedList.unites;
        }
    }
}
