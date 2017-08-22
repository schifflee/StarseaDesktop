using System.Collections.Generic;
using System.Xml.Serialization;

namespace Starsea.Framework.Model.XML
{
    public class RibbonQuickToolBar
    {
        [XmlElement("Item")]
        public List<RibbonItem> ItemList { get; set; }
    }
}