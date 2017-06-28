using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl
{
    public class UIBarManager : DotNetBarManager
    {

        public UIBarManager(IContainer container)
        {
            //this.Images = this.imageList1;
            this.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.EnableFullSizeDock = false;


            // this.ParentForm = this;

            this.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;


        }
    }
}
