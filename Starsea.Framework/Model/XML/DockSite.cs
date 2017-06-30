using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Starsea.Framework.Model.XML
{
    public class DockSite
    {
        [XmlAttribute("site")]
        public string site { get; set; }
        [XmlElement("Bar")]
        public DockSiteBar Bar { get; set; }

        [XmlElement("Width")]
        public int Width { get; set; }

        [XmlElement("Height")]
        public int Height { get; set; }

    }

}
