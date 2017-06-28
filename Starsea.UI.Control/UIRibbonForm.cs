using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Starsea.UIControl
{
   public class UIRibbonForm:RibbonForm
    {
        public void InitializeComponent() {

           

            //  styleManager1= new DevComponents.DotNetBar.StyleManager(this.components);
            // 
            // styleManager1
            // 
            ///this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            //  this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // frmMain
            // 

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
           
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
          
          
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            // this.Load += new System.EventHandler(this.frmMain_Load);
            // this.MdiChildActivate += new System.EventHandler(this.MdiChildActivated);
            // this.Move += new System.EventHandler(this.frmMain_Move);

           // this.SuspendLayout();
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1366, 700);
           // this.Name = "MainForm";
           // this.ResumeLayout(false);
        }

        private void frmMain_Closing(object sender, CancelEventArgs e)
        {
            this.Dispose();
        }

       
    }
}
