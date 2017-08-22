using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Starsea.Framework.Model.XML
{
    [XmlRoot("Ribbon")]
    public class Ribbon
    {
        [XmlElement("QuickToolBar")]
        public RibbonQuickToolBar QuickToolBar { get; set; }

        [XmlElement("ApplicationButton")]
        public RibbonApplicationButton ApplicationButton { get; set; }

        [XmlElement("Tab")]
        public List<RibbonTab> TabList { get; set; }


    }
}
