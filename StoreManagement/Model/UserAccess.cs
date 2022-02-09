using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StoreManagement.Model
{
    [Serializable, XmlRoot("UserAccess")]

    public class UserAccess
    {
        public int ID { get; set; }
        public string AccessName { get; set; }
        public bool Value { get; set; }
        public int UserID { get; set; }
    }
    [Serializable, XmlRoot("XMLUserAccess")]
    public class XMLUserAccess
    {
        public List<UserAccess> UsersAccess { get; set; }
    }
}
