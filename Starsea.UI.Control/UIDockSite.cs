using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl
{
    public class UIDockSite : DockSite
    {
        public UIDockSite()
        {
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            // this.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            // this.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            //  ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.bar3, 852, 95)))}, DevComponents.DotNetBar.eOrientation.Vertical);
            //this.Location = new System.Drawing.Point(0, 55);
            // this.Name = "dockSite1";
           
            // this.TabIndex = 6;
            this.TabStop = false;
            //  this.ResumeLayout(false);

        }
    }
}
