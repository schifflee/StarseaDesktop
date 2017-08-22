using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl
{
   public class UIRibbonControl:RibbonControl
    {

       public UIRibbonControl() {
            

            this.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CaptionVisible = true;
            // RibbonControl this = new DevComponents.DotNetBar.RibbonControl();
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
           // this.CaptionVisible = true;
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;

           // UIButtonItem bEditPopup = new UIButtonItem();

           //  DevComponents.DotNetBar.ContextMenuBar contextMenuBar1= new DevComponents.DotNetBar.ContextMenuBar();
           // ((System.ComponentModel.ISupportInitialize)(contextMenuBar1)).BeginInit();
           //contextMenuBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           //contextMenuBar1.IsMaximized = false;
           // contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
           // bEditPopup});
           // contextMenuBar1.Location = new System.Drawing.Point(352, 309);
           // contextMenuBar1.Name = "contextMenuBar1";
           // contextMenuBar1.Size = new System.Drawing.Size(150, 27);
           // contextMenuBar1.Stretch = true;
           // contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
           // contextMenuBar1.TabIndex = 13;
           // contextMenuBar1.TabStop = false;
            
           // this.GlobalContextMenuBar = contextMenuBar1;

            this.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.Location = new System.Drawing.Point(0, 20);
           // this.Name = "ribbonControl1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);

            this.Size = new System.Drawing.Size(900, 160);
            this.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;

            this.TabGroupHeight = 14;
            //this.TabIndex = 0;
           // this.Text = "ribbonControl1";

            // this.Dock = DockStyle.Top;
           // this.ResumeLayout(false);
           // this.PerformLayout();
           // this.ResumeLayout(false);
        }
    }
}
