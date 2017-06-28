using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl
{
    public class UIPanelDockContainer:PanelDockContainer
    {
        public UIPanelDockContainer() {
            this.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            //this.Controls.Add(this.textBox1);
            this.DisabledBackColor = System.Drawing.Color.Empty;
            // this.Location = new System.Drawing.Point(3, 28);
          
            //this.Size = new System.Drawing.Size(317, 122);
            this.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
            this.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.Style.GradientAngle = 90;
            //this.TabIndex = 0;

           
        }
    }
}
