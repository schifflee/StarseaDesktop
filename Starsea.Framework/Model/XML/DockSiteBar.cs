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
        [XmlAttribute("CloseSingleTab")]
        public bool CloseSingleTab { get; set; }

        [XmlAttribute("GrabHandleStyle")]
        public string GrabHandleStyle { get; set; }

        [XmlAttribute("AutoSyncBarCaption")]
        public bool AutoSyncBarCaption { get; set; }

        [XmlAttribute("AlwaysDisplayDockTab")]
        public bool AlwaysDisplayDockTab { get; set; }

        [XmlAttribute("CanCustomize")]
        public bool CanCustomize { get; set; }

        [XmlAttribute("CanDockBottom")]
        public bool CanDockBottom { get; set; }

        [XmlAttribute("CanDockDocument")]
        public bool CanDockDocument { get; set; }

        [XmlAttribute("CanDockLeft")]
        public bool CanDockLeft { get; set; }

        [XmlAttribute("CanDockRight")]
        public bool CanDockRight { get; set; }

        [XmlAttribute("CanDockTop")]
        public bool CanDockTop { get; set; }

        [XmlAttribute("CanUndock")]
        public bool CanUndock { get; set; }

        [XmlAttribute("CanHide")]
        public bool CanHide { get; set; }

        [XmlAttribute("Visible")]
        public bool Visible { get; set; }

        [XmlAttribute("DockTabAlignment")]
        public string DockTabAlignment { get; set; }

        [XmlAttribute("SelectedDockTab")]
        public string SelectedDockTab { get; set; }
    }
}
