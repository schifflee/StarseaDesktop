using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Starsea.Framework.Model.XML
{
    public class RibbonItem
    {
        [XmlAttribute("id")]
        public string ID { get; set; }

        [XmlAttribute("index")]
        public string INDEX { get; set; }

        [XmlAttribute("type")]
        public string TYPE { get; set; }

        [XmlAttribute("text")]
        public string TEXT { get; set; }

        [XmlAttribute("image")]
        public string IMAGE { get; set; }

        [XmlAttribute("dll")]
        public string DLL { get; set; }

        [XmlAttribute("class")]
        public string CLASS { get; set; }

        [XmlAttribute("func")]
        public string FUNC { get; set; }

        [XmlAttribute("windowtype")]
        public string WINDOWTYPE { get; set; }

    }
}
