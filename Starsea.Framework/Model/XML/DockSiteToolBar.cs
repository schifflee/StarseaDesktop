using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Starsea.Framework.Model.XML
{
   public class DockSiteToolBar
    {
        [XmlAttribute("site")]
        public string site { get; set; }

        [XmlElement("Bar")]
        public DockSiteToolBarBar Bar { get; set; }
    }
}
