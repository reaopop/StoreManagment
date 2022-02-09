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

    interface IXMLAccessUserSerializer
    {
        bool CreateOrUpdateInvoiceDetails(UserAccess acc);
        bool DeleteInoviceDetails(UserAccess acc);
        List<UserAccess> ReadInvoiceDetails();

    }
    public class XMLAccessUserSerializer : IXMLAccessUserSerializer
    {
        public string connection { get => (Master.XMLPath + "UserAccess.xml"); }
        bool PostData()
        {
            try
            {
                XMLUserAccess xml =  new XMLUserAccess() { UsersAccess = Database.UserAccess.ToList() };
                XmlSerializer serializer =
                new XmlSerializer(typeof(XMLUserAccess));
                TextWriter writer = new StreamWriter(connection, false, Encoding.UTF8);
                XMLUserAccess po = xml;

                serializer.Serialize(writer, po);
                writer.Flush
                    ();
                writer.Close();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool CreateOrUpdateInvoiceDetails(UserAccess acc)
        {
            Database.UserAccess.Add(acc);
            return PostData();
        }

        public bool DeleteInoviceDetails(UserAccess acc)
        {
            Database.UserAccess.Remove(acc);
            return PostData();
        }

        public List<UserAccess> ReadInvoiceDetails()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XMLUserAccess));
            FileStream fs = new FileStream(connection, FileMode.Open);
            XMLUserAccess dezerializedList = (XMLUserAccess)serializer.Deserialize(fs);
            return dezerializedList.UsersAccess;
        }
    }
}
