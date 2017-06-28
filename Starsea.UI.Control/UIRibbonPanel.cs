using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl
{
   public class UIRibbonPanel:RibbonPanel
    {

        public UIRibbonPanel() {

            this.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
          
            this.Dock = System.Windows.Forms.DockStyle.Fill;
           
            this.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
          
            //this.ResumeLayout(false);
        }
    }
}
