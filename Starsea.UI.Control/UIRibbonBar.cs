using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl
{
   public class UIRibbonBar: RibbonBar
    {

        public UIRibbonBar() {
            this.AutoOverflowEnabled = true;
            this.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ContainerControlProcessDialogKey = true;
            this.Dock = System.Windows.Forms.DockStyle.Left;
            this.DragDropSupport = true;
         
            this.Location = new System.Drawing.Point(0, 0);
         
            this.Size = new System.Drawing.Size(163, 100);
            this.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
           // this.TabIndex = 0;
            this.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.Text = "bar";
            this.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
        }
    }
}
