using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tp
{
    [XmlRoot]
    public class Class_test
    {
        [XmlElement]
        public int id { get; set; }
        [XmlAttribute(AttributeName = "Number")]
        public int number { get; set; }
        [XmlAttribute(AttributeName = "Title")]
        public string title { set; get; }
        [XmlAttribute(AttributeName = "Look")]
        public bool is_look { set; get; }

        public Class_test() { }
    }
}
