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
    interface IXMLUserSerilaizer
    {
		bool CreateOrUpdateUser(User user);
		bool DeleteUser(User user);
        List<User> ReadUsers();
		
    }
    public class XMLUserSerilaizer : IXMLUserSerilaizer
    {
        public string connection { get=>(Master.XMLPath+"User.xml"); }
        public bool CreateOrUpdateUser(User user)
        {
            Database.Users.Add(user);
            return PostData();
        }
        bool PostData()
        {
            try
            {
                XMLUser xml = new XMLUser() { Users = Database.Users.ToList() };
                XmlSerializer serializer =
                new XmlSerializer(typeof(XMLUser));
                TextWriter writer = new StreamWriter(connection, false, Encoding.UTF8);
                XMLUser po = xml;

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
        public bool DeleteUser(User user)
        {
            Database.Users.Remove(user);
            return PostData();
        }

        public List<User> ReadUsers()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XMLUser));
            FileStream fs = new FileStream(connection, FileMode.Open);
            XMLUser dezerializedList = (XMLUser)serializer.Deserialize(fs);
            return dezerializedList.Users;
        }
    }

}
