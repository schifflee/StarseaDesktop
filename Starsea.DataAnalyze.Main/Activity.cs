using Starsea.DataAnlalyze.UserObjectNav;
using Starsea.Framework.UICore;
using Starsea.UIControl;
using System.Windows.Forms;

namespace Starsea.DataAnalyze.Main
{
    public class Activity
    {
        public void ShowUserObject(UIDockSite docksite,string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper(); 
            UserObject ub = new UserObject();
            UserObject ub1 = new UserObject();
            dh.AddPanel(docksite, itemname, ub);
            dh.AddPanel(docksite, itemname, ub1);

        }

        public void ShowAllTable(UIDockSite docksite, string itemname) {
            DockPanelHelper dh = new DockPanelHelper();
            UserObject ub = new UserObject();           
            dh.AddPanel(docksite, itemname, ub);
        }

        public void ShowAllView(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            UserObject ub = new UserObject();
            dh.AddPanel(docksite, itemname, ub);
        }

        public void ShowAllFunction(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            UserObject ub = new UserObject();
            dh.AddPanel(docksite, itemname, ub);
        }


        public void ShowAllProcude(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            UserObject ub = new UserObject();
            dh.AddPanel(docksite, itemname, ub);
        }
    }
}
