using Starsea.UIControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starsea.Framework.UICore
{
   public class DockPanelHelper
    {
        public void AddPanel(UIDockSite docksite, string itemname,Control ctl) {

            UIBar uibar = docksite.Controls.Find("DockBar", true)[0] as UIBar;

            UIDockContainerItem dci = new UIDockContainerItem();
            uibar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { dci });
            UIPanelDockContainer pdc = new UIPanelDockContainer();
            uibar.Controls.Add(pdc);

            dci.Control = pdc;
            dci.Text = itemname;
          
            ctl.Dock = System.Windows.Forms.DockStyle.Fill;
            pdc.Controls.Add(ctl);
            uibar.Refresh();
        }

        public void RemovePanel() {

        }


        public void ShowPanel() { }


        public void HidePanel() { }
    }
}
