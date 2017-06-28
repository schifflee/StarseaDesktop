using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl
{
    public class UIBar : Bar
    {
        public UIBar()
        {
            this.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.AccessibleName = "DotNetBar Bar";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.AutoSyncBarCaption = true;
            this.AlwaysDisplayDockTab = true;
            this.CanCustomize = false;
            this.CanDockBottom = false;
            this.CanDockDocument = true;
            this.CanDockLeft = false;
            this.CanDockRight = false;
            this.CanDockTop = false;
            this.CanHide = true;
            this.CanUndock = false;
            // this.Controls.Add(this.panelDockContainer1);
            // this.Controls.Add(this.panelDockContainer3);
            // this.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IsMaximized = false;
            // this.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            //  this.dockContainerItem1,
            // this.dockContainerItem3});
            this.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.Location = new System.Drawing.Point(0, 0);
            // this.Name = "bar1";
            //this.SelectedDockTab = 0;
            this.Stretch = true;
            this.Size = new System.Drawing.Size(323, 153);
            this.Stretch = true;
            this.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            //this.TabIndex = 0;
            this.TabStop = false;
            this.Text = "bar";
            this.TabNavigation = true;
            this.GrabHandleStyle = eGrabHandleStyle.Caption;
            //
            //  ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // this.SuspendLayout();

        }
    }
}
