using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StoreManagement.Model
{
    [Serializable, XmlRoot("Unites")]

    public class Unites
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PerantID { get; set; }
    }
    [Serializable,XmlRoot("XMLUnite")]
    public class XMLUnite
    {
       public List<Unites> unites { get; set; }
    }
}
