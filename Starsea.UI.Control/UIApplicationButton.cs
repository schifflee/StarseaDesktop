using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl
{
   public class UIApplicationButton:ApplicationButton
    {

        public UIApplicationButton() {
            this.AutoExpandOnClick = true;
            this.CanCustomize = false;
            this.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
           // this.Image = ((System.Drawing.Image)(resources.GetObject("Image")));
            this.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.ImagePaddingHorizontal = 0;
            this.ImagePaddingVertical = 0;
          //  this.Name = "applicationButton1";
            this.ShowSubItems = false;
           // this.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {            this.itemContainer1});
            this.Text = "&文件";
            this.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;

        }
    }
}
