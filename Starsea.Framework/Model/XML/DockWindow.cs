using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Starsea.Framework.Model.XML
{
    [XmlRoot("Windows")]
   public class DockWindow
    {
        [XmlElement("DockSite")]
        public List<DockSite> DockSiteList { get; set; }

        [XmlElement("DockSiteToolBar")]
        public List<DockSite> DockSiteToolBarList { get; set; }
    }
}
