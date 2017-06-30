using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Starsea.Framework.Model.XML
{
    public class DockSiteBar
    {
        [XmlElement("CloseSingleTab")]
        public bool CloseSingleTab { get; set; }

        [XmlElement("GrabHandleStyle")]
        public string GrabHandleStyle { get; set; }

        [XmlElement("AutoSyncBarCaption")]
        public bool AutoSyncBarCaption { get; set; }

        [XmlElement("AlwaysDisplayDockTab")]
        public bool AlwaysDisplayDockTab { get; set; }

        [XmlElement("CanCustomize")]
        public bool CanCustomize { get; set; }

        [XmlElement("CanDockBottom")]
        public bool CanDockBottom { get; set; }

        [XmlElement("CanDockDocument")]
        public bool CanDockDocument { get; set; }

        [XmlElement("CanDockLeft")]
        public bool CanDockLeft { get; set; }

        [XmlElement("CanDockRight")]
        public bool CanDockRight { get; set; }

        [XmlElement("CanDockTop")]
        public bool CanDockTop { get; set; }

        [XmlElement("CanUndock")]
        public bool CanUndock { get; set; }

        [XmlElement("CanHide")]
        public bool CanHide { get; set; }

        [XmlElement("Visible")]
        public bool Visible { get; set; }

        [XmlElement("DockTabAlignment")]
        public string DockTabAlignment { get; set; }

        [XmlElement("SelectedDockTab")]
        public int SelectedDockTab { get; set; }
    }
}
