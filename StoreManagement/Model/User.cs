using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StoreManagement.Model
{
    [Serializable, XmlRoot("User")]
    public class User
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public bool IsActive { get; set; }
    }
    [Serializable, XmlRoot("XMLUser")]
    public class XMLUser
    {
       public List<User> Users { get; set; }
    }
}
