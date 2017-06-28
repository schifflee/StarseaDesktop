using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Starsea.Framework.Model.XML
{
    public class RibbonTab
    {
        [XmlAttribute("id")]
        public string ID { get; set; }

        [XmlAttribute("index")]
        public string INDEX { get; set; }

        [XmlAttribute("text")]
        public string TEXT { get; set; }

        [XmlElement("Bar")]
        public List<RibbonBar> BarList { get; set; }
    }
}
