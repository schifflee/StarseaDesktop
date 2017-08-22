using OVIT.BDC.MiddleLabrary.Controls;
using Starsea.UIControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVIT.BDC.MiddleLabrary.Main
{
    public class Activity
    {

        public void LoadFCSJ(UIDockSite docksite,string itemname) {
           // MessageBox.Show("加载界面");
            //加载 房产数据 树结构
            UIBar uibar = docksite.Controls.Find("DockBar", true)[0] as UIBar;

            UIDockContainerItem dci = new UIDockContainerItem();
            uibar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { dci });
            UIPanelDockContainer pdc = new UIPanelDockContainer();
            uibar.Controls.Add(pdc);

            dci.Control = pdc;
            dci.Text = itemname;

            FCList ub = new FCList();
            pdc.Controls.Add(ub);
            ub.Dock = System.Windows.Forms.DockStyle.Fill;

            uibar.Refresh();

            //加载 不动产 地图            

        }

        public void LoadBDCMapData(UIDockSite docksite, string itemname) {
            //MessageBox.Show("加载数据");

            UIBar uibar = docksite.Controls.Find("DockBar", true)[0] as UIBar;

            UIDockContainerItem dci = new UIDockContainerItem();
            uibar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { dci });
            UIPanelDockContainer pdc = new UIPanelDockContainer();
            uibar.Controls.Add(pdc);

            dci.Control = pdc;
            dci.Text = itemname;

            SdeMap ub = new SdeMap();
            pdc.Controls.Add(ub);
            ub.Dock = System.Windows.Forms.DockStyle.Fill;

            uibar.Refresh();

        }
    }
}
