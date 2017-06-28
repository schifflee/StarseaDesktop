using DevComponents.DotNetBar;
using Starsea.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl
{
    public partial class UIButtonItem : ButtonItem
    {
        public UIButtonItem()
        {
            this.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;           
            this.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
          //  this.Image = System.Drawing.Image.FromFile(ConfigHelper.ImagePath+"Menu\\Document.png");
           
            this.Visible = true;
            this.Text = "按钮";
        }

      
    }
}
