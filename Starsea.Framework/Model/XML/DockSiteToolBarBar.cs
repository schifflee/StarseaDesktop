using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Starsea.Framework.Model.XML
{
   public class DockSiteToolBarBar
    {
        [XmlElement("Visible")]
        public bool Visible { get; set; }

        [XmlElement("LayoutType")]
        public string LayoutType { get; set; }
    }
}
