using System.Xml.Serialization;

namespace Starsea.Framework.Model.XML
{
    public class RibbonApplicationButton
    {
        [XmlAttribute("text")]
        public string TEXT { get; set; }


        [XmlAttribute("visible")]
        public bool VISIBLE { get; set; }

    }
}