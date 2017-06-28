using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Starsea.UIControl
{
    public partial class UITabStrip : TabStrip
    {
        public UITabStrip()
        {
            this.AutoSelectAttachedControl = true;
            this.CanReorderTabs = true;
            this.CloseButtonOnTabsVisible = true;
            this.CloseButtonVisible = false;
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(5, 152);
           
            this.MdiTabbedDocuments = true;
            this.Name = "tabStrip1";
            this.SelectedTab = null;
            this.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size = new System.Drawing.Size(873, 26);
            this.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.TabIndex = 6;
            this.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.Text = "tabStrip1";
        }
    }
}
